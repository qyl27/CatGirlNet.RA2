using System.ComponentModel.DataAnnotations;
using CatGirlNet.RA2.Game.Enums;

namespace CatGirlNet.RA2.Game.Player;

public class AISide : Side
{
    [Required]
    public AIDifficuty Difficulty { get; set; }
}