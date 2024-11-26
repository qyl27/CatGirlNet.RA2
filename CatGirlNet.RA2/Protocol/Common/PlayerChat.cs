using CatGirlNet.RA2.Platform;

namespace CatGirlNet.RA2.Protocol.Common;

public class PlayerChat
{
    public required Player Player { get; set; }
    
    public required string Content { get; set; }
}