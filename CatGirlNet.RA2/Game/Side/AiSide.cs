using System.ComponentModel.DataAnnotations;
using CatGirlNet.RA2.Game.Enums;

namespace CatGirlNet.RA2.Game.Side;

public class AiSide : Side
{
    [Required]
    public AiDifficuty Difficulty { get; set; }
}