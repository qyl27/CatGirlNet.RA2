using System.ComponentModel.DataAnnotations;
using CatGirlNet.RA2.Core.Model.Enums;

namespace CatGirlNet.RA2.Core.Model;

public class AIPlayer : Player
{
    [Required]
    public AIDifficuty Difficulty { get; set; }
}