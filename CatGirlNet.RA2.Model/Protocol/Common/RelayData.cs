namespace CatGirlNet.RA2.Model.Protocol.Common;

public class RelayData
{
    public required uint SenderId { get; set; }
    
    public required uint ReceiverId { get; set; }
    
    public required byte[] Data { get; set; }
}