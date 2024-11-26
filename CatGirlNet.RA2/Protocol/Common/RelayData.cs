namespace CatGirlNet.RA2.Protocol.Common;

public class RelayData
{
    public required int SenderId { get; set; }
    
    public required int ReceiverId { get; set; }
    
    public required byte[] Data { get; set; }
}