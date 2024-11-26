namespace CatGirlNet.RA2.Platform;

public class Player
{
    public required Guid Id { get; set; }
    
    public required string Name { get; set; }
    
    public Room? Room { get; set; }
    
    public bool IsInRoom => Room is not null;
}