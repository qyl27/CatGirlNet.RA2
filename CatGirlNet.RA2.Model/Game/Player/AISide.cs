using System.ComponentModel.DataAnnotations;
using CatGirlNet.RA2.Model.Game.Enums;

namespace CatGirlNet.RA2.Model.Game.Player;

public class AISide : Side
{
    [Required]
    public AIDifficuty Difficulty { get; set; }
}