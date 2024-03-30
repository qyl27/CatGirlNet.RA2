namespace CatGirlNet.RA2.Core.Model;

public class LocalConfig
{
    public bool HideLoadingMap { get; set; } = false;
    public bool HidePlayerName { get; set; } = false;

    public ushort LocalPort { get; set; } = 33927;
}