using IniParser.Model;

namespace CatGirlNet.RA2.Model.Game.Config;

/// <summary>
/// RA2MD.INI
/// </summary>
public class LocalGameConfig : IConfig
{
    /// <summary>
    /// Disable edge scrolling.
    /// Recommended when Borderless Windowed.
    /// </summary>
    public bool DisableEdgeScrolling { get; set; } = false;
    
    /// <summary>
    /// Supports ALT+F4.
    /// Safely than DDrawHandlesClose.
    /// </summary>
    public bool QuickExit { get; set; } = false;
    
    /// <summary>
    /// Supports ALT+F4 by cnc-ddraw.
    /// It's not secure, but faster.
    /// Requires the cnc-ddraw.
    /// </summary>
    public bool DDrawHandlesClose { get; set; } = false;
    
    /// <summary>
    /// Just skip score screen.
    /// </summary>
    public bool SkipScoreScreen { get; set; } = false;
    
    /// <summary>
    /// Multiplayer debugging mode.
    /// </summary>
    public bool MultiplayerDebug { get; set; } = false;
    
    /// <summary>
    /// Force game to use only one processor core.
    /// Maybe needn't it in most situation.
    /// </summary>
    public bool SingleCore { get; set; } = false;
    
    /// <summary>
    /// Windowed mode.
    /// </summary>
    public bool Windowed { get; set; } = false;
    
    /// <summary>
    /// Borderless windowed mode.
    /// </summary>
    public bool Borderless { get; set; } = false;

    /// <summary>
    /// Sets the target FPS.
    /// -1 for disable.
    /// Requires the ts-ddraw.
    /// </summary>
    public int DDrawTargetFPS { get; set; } = -1;
    
    public void Write(IniData data)
    {
        data["Options"]["DisableEdgeScrolling"] = IConfig.ToGameBool(DisableEdgeScrolling);
        data["Options"]["QuickExit"] = IConfig.ToGameBool(QuickExit);
        data["Options"]["DDrawHandlesClose"] = IConfig.ToGameBool(DDrawHandlesClose);
        data["Options"]["SkipScoreScreen"] = IConfig.ToGameBool(SkipScoreScreen);
        data["Options"]["MPDEBUG"] = IConfig.ToGameBool(MultiplayerDebug);
        data["Options"]["SingleProcAffinity"] = IConfig.ToGameBool(SingleCore);
        
        data["Video"]["Video.Windowed"] = IConfig.ToGameBool(Windowed);
        data["Video"]["NoWindowFrame"] = IConfig.ToGameBool(Borderless);
        data["Video"]["DDrawTargetFPS"] = DDrawTargetFPS.ToString();
    }

    public void Read(IniData data)
    {
        DisableEdgeScrolling = IConfig.FromGameBool(data["Options"]["DisableEdgeScrolling"]);
        QuickExit = IConfig.FromGameBool(data["Options"]["QuickExit"]);
        DDrawHandlesClose = IConfig.FromGameBool(data["Options"]["DDrawHandlesClose"]);
        SkipScoreScreen = IConfig.FromGameBool(data["Options"]["SkipScoreScreen"]);
        MultiplayerDebug = IConfig.FromGameBool(data["Options"]["MPDEBUG"]);
        SingleCore = IConfig.FromGameBool(data["Options"]["SingleProcAffinity"]);
        
        Windowed = IConfig.FromGameBool(data["Video"]["Video.Windowed"]);
        Borderless = IConfig.FromGameBool(data["Video"]["NoWindowFrame"]);
        DDrawTargetFPS = IConfig.FromGameInt(data["Video"]["DDrawTargetFPS"], -1);
    }
}