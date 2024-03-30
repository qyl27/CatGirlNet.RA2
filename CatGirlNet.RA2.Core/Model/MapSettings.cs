using System.ComponentModel.DataAnnotations;

namespace CatGirlNet.RA2.Core.Model;

public class MapSettings
{
    /// <summary>
    /// Todo: whats mean here?
    /// </summary>
    public int GameMode { get; set; } = 1;

    /// <summary>
    /// Tech level.
    /// In vanilla, it should be 0 ~ 10.
    /// Todo: can be modify in rules.ini?
    /// </summary>
    [Range(0, 10)]
    public int TechLevel { get; set; } = 10;

    /// <summary>
    /// Todo: means spawn with base or not? 
    /// </summary>
    public bool Bases { get; set; } = true;

    /// <summary>
    /// RA3 style Fog of War. 
    /// </summary>
    public bool FogOfWar { get; set; } = false;

    /// <summary>
    /// Initial credits per player.
    /// Vanilla value is 10000.
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
    /// If players will defeated when its all buildings are destroyed.
    /// </summary>
    public bool FastGame { get; set; } = true;

    /// <summary>
    /// Allow move MCV or not.
    /// </summary>
    public bool RedeployMCV { get; set; } = true;

    /// <summary>
    /// Should crates spawns or not.
    /// </summary>
    public bool Chests { get; set; } = false;

    /// <summary>
    /// Allow super weapons or not.
    /// </summary>
    public bool SuperWeapons { get; set; } = true;

    /// <summary>
    /// Todo: maybe in game ally?
    /// </summary>
    public bool AlliesAllowed { get; set; } = true;

    /// <summary>
    /// Allow to build near the MCV of allies or not.
    /// </summary>
    public bool BuildOffAlly { get; set; } = true;

    /// <summary>
    /// If enable, engineers can't capture building, but give it some damage.
    /// (TS engine function.)
    /// </summary>
    public bool MultiEngineer { get; set; } = false;

    /// <summary>
    /// If enable, bridge can't be destroyed.
    /// </summary>
    public bool BridgeDestroy { get; set; } = true;

    /// <summary>
    /// Todo: means the side named neutral?
    /// </summary>
    public bool AttackNeutralUnits { get; set; } = true;
    
    /// <summary>
    /// Todo: what?
    /// </summary>
    public bool SidebarHack { get; set; } = true;
}