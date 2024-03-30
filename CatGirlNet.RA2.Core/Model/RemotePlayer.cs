using System.ComponentModel.DataAnnotations;
using System.Net;

namespace CatGirlNet.RA2.Core.Model;

public class RemotePlayer : Player
{
    [Required]
    public required IPAddress Ip { get; set; }
    
    [Required]
    public required ushort Port { get; set; } 
}