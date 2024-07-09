namespace CatGirlNet.RA2.Model.Protocol.Common;

public class RelayData
{
    public required int SenderId { get; set; }
    
    public required int ReceiverId { get; set; }
    
    public required byte[] Data { get; set; }
}