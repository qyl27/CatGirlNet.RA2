﻿using System.ComponentModel.DataAnnotations;
using CatGirlNet.RA2.Model.Game.Enums;

namespace CatGirlNet.RA2.Model.Game.Player;

public class Side
{
    [Required]
    [MaxLength(60)]
    public required string Name { get; set; }
    
    [Required]
    public Color Color { get; set; }

    [Required]
    public Country Country { get; set; }
    
    [Required] 
    public bool IsObserver { get; set; } = false;

    /// <summary>
    /// 0 ~ 7: waypoints 0 ~ 7 in map.
    /// -1: disable.
    /// -2: random.
    /// </summary>
    [Required]
    [Range(-2, 7)]
    public int SpawnLocation { get; set; } = -2;
}