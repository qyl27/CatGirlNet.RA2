using IniParser.Model;

namespace CatGirlNet.RA2.Model.Game.Config;

public interface IConfig
{
    public static int FromGameInt(string value, int defaultValue)
    {
        return int.TryParse(value, out var i) ? i : defaultValue;
    }
    
    public static bool FromGameBool(string value)
    {
        return value.Equals("yes", StringComparison.CurrentCultureIgnoreCase);
    }
    
    public static string ToGameBool(bool value)
    {
        return value ? "yes" : "no";
    }
    
    public void Write(IniData data);
    
    public void Read(IniData data);
}