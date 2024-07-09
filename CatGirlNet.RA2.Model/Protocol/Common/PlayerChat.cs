using CatGirlNet.RA2.Model.Platform;

namespace CatGirlNet.RA2.Model.Protocol.Common;

public class PlayerChat
{
    public required Player Player { get; set; }
    
    public required string Content { get; set; }
}