using CatGirlNet.RA2.Game.Config;
using CatGirlNet.RA2.Game.Side;

namespace CatGirlNet.RA2.Platform;

public class Room
{
    public string RoomName { get; set; }
    
    public List<Player> Players { get; set; } = new();

    public LaunchConfig? LaunchConfig { get; set; } = new()
    {
        Sides =
        {
            // new Side()
        }
    };
}