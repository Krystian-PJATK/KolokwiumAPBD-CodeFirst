using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumAPBD_CodeFirst.Models;

[Table("Race_Participation")]
[PrimaryKey(nameof(TrackRaceId), nameof(RacerId))]
public class RaceParticipation
{
    public int TrackRaceId { get; set; }
    public int RacerId { get; set; }
    
    public int FinishTimeInSeconds { get; set; }
    
    public int Position { get; set; }
    
    [ForeignKey(nameof(TrackRaceId))]
    public TrackRace TrackRace { get; set; }
    
    [ForeignKey(nameof(RacerId))]
    public Racer Racer { get; set; }
    
}