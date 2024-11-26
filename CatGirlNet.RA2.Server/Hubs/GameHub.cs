using CatGirlNet.RA2.Server.Service;
using Microsoft.AspNetCore.SignalR;

namespace CatGirlNet.RA2.Server.Hubs;

public partial class GameHub(PlayerService playerService, RoomService roomService) : Hub
{
}