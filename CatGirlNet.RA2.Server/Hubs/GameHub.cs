using CatGirlNet.RA2.Model.Protocol.Common;
using Microsoft.AspNetCore.SignalR;

namespace CatGirlNet.RA2.Server.Hubs;

public class GameHub : Hub
{
    public async Task JoinRoom()
    {
        
    }

    public async Task LeaveRoom()
    {
        
    }
    
    public async Task Relay(RelayData data)
    {
        Console.WriteLine($"Forwarding from {data.SenderId}({Context.ConnectionId}) to {data.ReceiverId}");
        await Clients.AllExcept(Context.ConnectionId).SendAsync("OnRelay", data);
        
        // if (GameIdToConnectionId.TryGetValue(data.SenderId, out var senderConnectionId))
        // {
        //     if (senderConnectionId != Context.ConnectionId)
        //     {
        //         GameIdToConnectionId[data.SenderId] = Context.ConnectionId;
        //     }
        // }
        // else
        // {
        //     GameIdToConnectionId.Add(data.SenderId, Context.ConnectionId);
        // }
        //
        // if (GameIdToConnectionId.TryGetValue(data.ReceiverId, out var receiverConnectionId))
        // {
        //     await Clients.Client(receiverConnectionId).SendAsync("OnRelay", data);
        // }
    }
}