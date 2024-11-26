using System.Net;

namespace CatGirlNet.RA2.Game.Side;

public class RemoteSide : Side
{
    // We're always use tunnel.
    public IPAddress? Ip { get; } = null;

    public required ushort Port { get; set; } = Constants.RemotePlayer1Port;
}