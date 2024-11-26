using System.ComponentModel.DataAnnotations;
using IniParser.Model;

namespace CatGirlNet.RA2.Game.Config;

/// <summary>
/// SPAWN.INI
/// </summary>
public class GameModeConfig : IConfig
{
    #region Unavailable

    /// <summary>
    /// [Unavailable]
    /// Todo: We haven't more game mode support yet. It needs more custom rules.ini.
    /// Value example: 
    /// 1: Battle
    /// 2: Free Battle
    /// 3: Cooperative
    /// </summary>
    public int GameMode { get; private set; } = 1;

    /// <summary>
    /// [Unavailable]
    /// Todo: spawn with base or not? 
    /// </summary>
    public bool Bases { get; private set; } = true;
    
    /// <summary>
    /// [Unavailable]
    /// Todo: the side named neutral?
    /// </summary>
    public bool AttackNeutralUnits { get; private set; } = true;
    
    /// <summary>
    /// [Unavailable]
    /// Todo: what?
    /// </summary>
    public bool SidebarHack { get; private set; } = true;

    #endregion
    
    /// <summary>
    /// Use Ra2 rules instead of Yuri.
    /// </summary>
    public bool Ra2Mode { get; set; } = true;
    
    /// <summary>
    /// Tech level.
    /// In vanilla, it should be 0 ~ 10.
    /// Todo: the range can be modify in rules.ini?
    /// </summary>
    [Range(0, 10)]
    public int TechLevel { get; set; } = 10;
    
    /// <summary>
    /// Initial credits per player.
    /// Vanilla range is 5000 ~ 10000.
    /// </summary>
    [Range(0, 50000)]   // Todo: really want so much credits?
    public int Credits { get; set; } = 10000;
    
    /// <summary>
    /// Initial unit count, contains T1 soldiers and tanks.
    /// Vanilla range is 0 ~ 10.
    /// </summary>
    [Range(0, 25)]
    public int UnitCount { get; set; } = 0;
    
    /// <summary>
    /// Game speed.
    /// 0 is fastest (as fast as computer can, 6 in game).
    /// 1 is 60 fps (5 in game).
    /// 2 is 30 fps (4 in game).
    /// 3 is 20 fps (3 in game).
    /// 4 is 15 fps (2 in game).
    /// 5 is 10 fps (1 in game).
    /// </summary>
    [Range(0, 5)]
    public int GameSpeed { get; set; } = 0;

    /// <summary>
    /// RA3 style Fog of War. 
    /// </summary>
    public bool FogOfWar { get; set; } = false;

    /// <summary>
    /// If player will be defeated when it's all buildings are destroyed.
    /// </summary>
    public bool FastGame { get; set; } = true;

    /// <summary>
    /// Allow move MCV or not.
    /// </summary>
    public bool RedeployMCV { get; set; } = true;

    /// <summary>
    /// Should crate spawns or not.
    /// </summary>
    public bool Crates { get; set; } = false;
    
    /// <summary>
    /// Allow super weapons or not.
    /// </summary>
    public bool SuperWeapons { get; set; } = true;

    /// <summary>
    /// In-game ally.
    /// </summary>
    public bool AlliesAllowed { get; set; } = true;

    /// <summary>
    /// Allow to build near the MCV of allies or not.
    /// </summary>
    public bool BuildOffAlly { get; set; } = true;

    /// <summary>
    /// If enabled, engineers can't capture building, but give it some damage.
    /// (TS engine function. Like RA1.)
    /// </summary>
    public bool MultiEngineer { get; set; } = false;

    /// <summary>
    /// If enabled, bridge can't be destroyed.
    /// </summary>
    public bool BridgeDestroy { get; set; } = true;

    public void Write(IniData data)
    {
        data["Settings"]["GameMode"] = GameMode.ToString();
        data["Settings"]["Bases"] = IConfig.ToGameBool(Bases);
        data["Settings"]["AttackNeutralUnits"] = IConfig.ToGameBool(AttackNeutralUnits);
        data["Settings"]["SidebarHack"] = IConfig.ToGameBool(SidebarHack);

        data["Settings"]["Ra2Mode"] = IConfig.ToGameBool(Ra2Mode);
        data["Settings"]["TechLevel"] = TechLevel.ToString();
        data["Settings"]["Credits"] = Credits.ToString();
        data["Settings"]["UnitCount"] = UnitCount.ToString();
        data["Settings"]["GameSpeed"] = GameSpeed.ToString();
        data["Settings"]["FogOfWar"] = IConfig.ToGameBool(FogOfWar);
        data["Settings"]["ShortGame"] = IConfig.ToGameBool(FastGame);
        data["Settings"]["MCVRedeploy"] = IConfig.ToGameBool(RedeployMCV);
        data["Settings"]["Crates"] = IConfig.ToGameBool(Crates);
        data["Settings"]["Superweapons"] = IConfig.ToGameBool(SuperWeapons);
        data["Settings"]["AlliesAllowed"] = IConfig.ToGameBool(AlliesAllowed);
        data["Settings"]["BuildOffAlly"] = IConfig.ToGameBool(BuildOffAlly);
        data["Settings"]["MultiEngineer"] = IConfig.ToGameBool(MultiEngineer);
        data["Settings"]["BridgeDestroy"] = IConfig.ToGameBool(BridgeDestroy);
    }

    public void Read(IniData data)
    {
        GameMode = IConfig.FromGameInt(data["Settings"]["GameMode"], 1);
        Bases = IConfig.FromGameBool(data["Settings"]["Bases"]);
        AttackNeutralUnits = IConfig.FromGameBool(data["Settings"]["AttackNeutralUnits"]);
        SidebarHack = IConfig.FromGameBool(data["Settings"]["SidebarHack"]);
        
        Ra2Mode = IConfig.FromGameBool(data["Settings"]["Ra2Mode"]);
        TechLevel = IConfig.FromGameInt(data["Settings"]["TechLevel"], 10);
        Credits = IConfig.FromGameInt(data["Settings"]["Credits"], 10000);
        UnitCount = IConfig.FromGameInt(data["Settings"]["UnitCount"], 0);
        GameSpeed = IConfig.FromGameInt(data["Settings"]["GameSpeed"], 0);
        FogOfWar = IConfig.FromGameBool(data["Settings"]["FogOfWar"]);
        FastGame = IConfig.FromGameBool(data["Settings"]["ShortGame"]);
        RedeployMCV = IConfig.FromGameBool(data["Settings"]["MCVRedeploy"]);
        Crates = IConfig.FromGameBool(data["Settings"]["Crates"]);
        SuperWeapons = IConfig.FromGameBool(data["Settings"]["Superweapons"]);
        AlliesAllowed = IConfig.FromGameBool(data["Settings"]["AlliesAllowed"]);
        BuildOffAlly = IConfig.FromGameBool(data["Settings"]["BuildOffAlly"]);
        MultiEngineer = IConfig.FromGameBool(data["Settings"]["MultiEngineer"]);
        BridgeDestroy = IConfig.FromGameBool(data["Settings"]["BridgeDestroy"]);
    }
}