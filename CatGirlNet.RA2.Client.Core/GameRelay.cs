using System.Net;
using System.Net.Sockets;
using CatGirlNet.RA2.Model.Protocol.Common;

namespace CatGirlNet.RA2.Client.Core;

public class GameRelay : IDisposable
{
    public const int SioUdpConnReset = -1744830452; // SIO_UDP_CONNRESET
    
    private OnlineClient OnlineClient { get; }
    private UdpClient UdpClient { get; }
    
    public GameRelay(OnlineClient onlineClient, IPEndPoint relayEndPoint, IPEndPoint localGame)
    {
        OnlineClient = onlineClient;
        UdpClient = new UdpClient(relayEndPoint);
        
        UdpClient.Client.SendTimeout = 5000;
        UdpClient.Client.ReceiveTimeout = 5000;

        OnlineClient.OnRelay += data =>
        {
            UdpClient.Client.SendTo(data.Data, localGame);
        };
    }

    public void Start()
    {
        try
        {
            UdpClient.Client.IOControl(SioUdpConnReset, [0, 0, 0, 0], null);
        }
        catch (Exception ex)
        {
            // ignored
        }

        UdpClient.BeginReceive(OnReceive, UdpClient);
    }

    public void OnReceive(IAsyncResult ar)
    {
        var client = (ar.AsyncState as UdpClient)!;
        var endPoint = (IPEndPoint) client.Client.LocalEndPoint!;
        var bytes = client.EndReceive(ar, ref endPoint);

        if (bytes.Length >= 4)
        {
            // qyl27: CnCNet spawner use the port as id.
            var senderId = IPAddress.NetworkToHostOrder(BitConverter.ToUInt16(bytes, 0));
            var receiverId = IPAddress.NetworkToHostOrder(BitConverter.ToUInt16(bytes, 2));
            OnlineClient.Send(new RelayData
            {
                SenderId = senderId, 
                ReceiverId = receiverId, 
                Data = bytes
            });
        }

        client.BeginReceive(OnReceive, ar.AsyncState);
    }

    public void Stop()
    {
        UdpClient.Close();
    }

    public void Dispose()
    {
        UdpClient.Dispose();
    }
}