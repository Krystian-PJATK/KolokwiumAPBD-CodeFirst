﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumAPBD_CodeFirst.Models;

[Table("Track_Race")]
public class TrackRace
{
    [Key]
    public int TrackRaceId { get; set; }
    public int TrackId { get; set; }
    public int RaceId { get; set; }
    
    public int Laps { get; set; }
    
    public int? BestTimeInSeconds { get; set; }
    
    public ICollection<RaceParticipation> RaceParticipations { get; set; } = null!;
    
    [ForeignKey(nameof(TrackId))]
    public Track Track { get; set; } = null!;
    [ForeignKey(nameof(RaceId))]
    public Race Race { get; set; } = null!;
}