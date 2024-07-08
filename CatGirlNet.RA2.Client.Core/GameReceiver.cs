using System.Net;
using System.Net.Sockets;
using CatGirlNet.RA2.Model.Protocol.Common;

namespace CatGirlNet.RA2.Client.Core;

public class GameReceiver : IDisposable
{
    public const int SioUdpConnReset = -1744830452; // SIO_UDP_CONNRESET
    public static readonly IPEndPoint RemoteEndPoint = new(IPAddress.Any, 0);
    
    private OnlineClient OnlineClient { get; }
    private UdpClient UdpClient { get; }
    private HashSet<IPEndPoint> EndPoints { get; } = new();
    
    public GameReceiver(OnlineClient onlineClient, IPEndPoint endPoint)
    {
        OnlineClient = onlineClient;
        UdpClient = new UdpClient(endPoint);
        
        UdpClient.Client.SendTimeout = 5000;
        UdpClient.Client.ReceiveTimeout = 5000;

        OnlineClient.OnRelay += data =>
        {
            foreach (var ep in EndPoints)
            {
                UdpClient.Client.SendTo(data.Data, ep);
            }
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
        var endPoint = RemoteEndPoint;
        var client = (ar.AsyncState as UdpClient)!;
        var bytes = client.EndReceive(ar, ref endPoint);

        if (bytes.Length >= 8)
        {
            if (endPoint is not null)
            {
                EndPoints.Add(endPoint);
            }
            
            var senderId = BitConverter.ToUInt32(bytes, 0);
            var receiverId = BitConverter.ToUInt32(bytes, 4);
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