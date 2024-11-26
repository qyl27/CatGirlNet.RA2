using System.Collections.Concurrent;
using CatGirlNet.RA2.Platform;

namespace CatGirlNet.RA2.Server.Service;

public class PlayerService
{
    private ConcurrentDictionary<Guid, Player> _players = new();
    
    public PlayerService()
    {
        
    }

    public void PlayerJoin(Player player)
    {
        
    }
}