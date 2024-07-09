using System.Net;
using CatGirlNet.RA2.Model.Game.Enums;
using CatGirlNet.RA2.Model.Game.Player;

namespace CatGirlNet.RA2.Model.Game;

public class GameConfig
{
    public string UIGameMode { get; set; }
    public string UIMapName { get; set; }

    public int RandomSeed { get; set; } = new Random().Next(int.MinValue, int.MaxValue);

    public IEnumerable<Side> Sides { get; } = new List<Side>(8);

    #region Networking
    
    public NetProtocol Protocol { get; set; }
    
    public int PreCalcMaxAhead { get; set; }    // Dynamic
    public int MaxLatencyLevel { get; set; }    // Dynamic
    
    public int FrameSendRate { get; set; }      // Default 
    public int MaxAhead { get; set; }           // Default 
    
    public int ReconnectTimeout { get; set; }
    public int ConnTimeout { get; set; }
    
    public IPAddress TunnelIp { get; set; }
    public ushort TunnelPort { get; set; } 

    #endregion
}