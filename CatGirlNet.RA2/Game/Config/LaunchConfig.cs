using IniParser.Model;

namespace CatGirlNet.RA2.Game.Config;

public class LaunchConfig : IConfig
{
    /// <summary>
    /// Map name shows in players list.
    /// </summary>
    public string UIMapName { get; set; } = "猫猫糕 (2)";
    
    /// <summary>
    /// Game mode shows in players list.
    /// </summary>
    public string UIGameMode { get; set; } = "猫娘网络 作战模式";
    
    /// <summary>
    /// Random seed of game.
    /// </summary>
    public int RandomSeed { get; set; } = new Random().Next(int.MinValue, int.MaxValue);

    /// <summary>
    /// Single player.
    /// </summary>
    public bool SinglePlayer { get; set; } = false;
    
    /// <summary>
    /// Hide players' name.
    /// </summary>
    public bool HidePlayersName { get; set; } = false;
    
    /// <summary>
    /// Skip score screen, same as Local config.
    /// </summary>
    public bool SkipScoreScreen { get; set; } = false;
    
    /// <summary>
    /// The match statistics will be saved in the stats.dmp file.
    /// </summary>
    public bool WriteStatistics { get; set; } = false;
    
    /// <summary>
    /// Show GUI_AIEasy, GUI_AINormal, GUI_AIHard instead of TXT_COMPUTER.
    /// </summary>
    public bool ShowAINamesWithDifficulty { get; set; } = true;
    
    /// <summary>
    /// Continue after all human player are lost.
    /// </summary>
    public bool ContinueWithoutHumans { get; set; } = false;
    
    /// <summary>
    /// The lost players will automatically switch to observer mode.
    /// </summary>
    public bool DefeatedBecomesObserver { get; set; } = true;
    
    /// <summary>
    /// Show AI players in the observer panel.
    /// </summary>
    public bool ShowAIOnObserverSidebar { get; set; } = false;
    
    /// <summary>
    /// Will parsed to config.
    /// </summary>
    public IEnumerable<Side.Side> Sides { get; } = new List<Side.Side>(8);

    #region Unavailable

    /// <summary>
    /// [Unavailable]
    /// Map file content.
    /// </summary>
    public string MapContent { get; private set; } = string.Empty;
    
    /// <summary>
    /// [Unavailable]
    /// SHA-1 of map.
    /// </summary>
    public string MapHash { get; private set; } = string.Empty;
    
    /// <summary>
    /// [Unavailable]
    /// Todo: Spawners are only read spawnmap.ini.
    /// </summary>
    public string ScenarioName { get; private set; } = "spawnmap.ini";

    /// <summary>
    /// [Unavailable]
    /// </summary>
    public int Tournament { get; set; } = 0;
    
    /// <summary>
    /// [Unavailable]
    /// WOL game id.
    /// </summary>
    public int WOLGameID { get; private set; } = 0;

    #endregion
    
    public void Write(IniData data)
    {
        throw new NotImplementedException();
    }

    public void Read(IniData data)
    {
        throw new NotImplementedException();
    }
}