using System.Net;
using CatGirlNet.RA2.Game.Enums;
using CatGirlNet.RA2.Model.Game.Enums;
using IniParser.Model;

namespace CatGirlNet.RA2.Game.Config;

/// <summary>
/// SPAWN.INI
/// </summary>
public class NetworkConfig : IConfig
{
    /// <summary>
    /// Default protocol is unavailable now.
    /// </summary>
    public NetProtocol Protocol { get; set; } = NetProtocol.Dynamic;

    public int PreCalcMaxAhead { get; set; } = 0;       // Dynamic
    public int MaxLatencyLevel { get; set; } = 255;     // Dynamic

    public int FrameSendRate { get; set; } = 4;         // Default 
    public int MaxAhead { get; set; } = -1;             // Default 

    public int ReconnectTimeout { get; set; } = 2400;
    public int ConnTimeout { get; set; } = 3600;

    public ushort LocalPort { get; set; } = 50010;
    
    public IPAddress TunnelIp { get; set; } = IPAddress.Loopback;
    public ushort TunnelPort { get; set; } = 50009;

    public void Write(IniData data)
    {
        data["Settings"]["Protocol"] = ((int)Protocol).ToString();
        switch (Protocol)
        {
            case NetProtocol.Dynamic:
                data["Settings"]["PreCalcMaxAhead"] = PreCalcMaxAhead.ToString();
                data["Settings"]["MaxLatencyLevel"] = MaxLatencyLevel.ToString();
                break;
            case NetProtocol.Default:
                data["Settings"]["FrameSendRate"] = FrameSendRate.ToString();
                data["Settings"]["MaxAhead"] = MaxAhead.ToString();
                break;
        }
        data["Settings"]["ReconnectTimeout"] = ReconnectTimeout.ToString();
        data["Settings"]["ConnTimeout"] = ConnTimeout.ToString();
        
        data["Settings"]["Port"] = LocalPort.ToString();
        data["Tunnel"]["Ip"] = TunnelIp.ToString();
        data["Tunnel"]["Port"] = TunnelPort.ToString();
    }

    public void Read(IniData data)
    {
        throw new NotImplementedException();
    }
}