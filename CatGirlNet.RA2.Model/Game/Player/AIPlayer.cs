using System.ComponentModel.DataAnnotations;
using CatGirlNet.RA2.Model.Game.Enums;

namespace CatGirlNet.RA2.Model.Game.Player;

public class AIPlayer : Player
{
    [Required]
    public AIDifficuty Difficulty { get; set; }
}