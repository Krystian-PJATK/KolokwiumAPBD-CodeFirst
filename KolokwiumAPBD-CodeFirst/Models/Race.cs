using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumAPBD_CodeFirst.Models;

[Table("Race")]
public class Race
{
    [Key]
    public int RaceId { get; set; }
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    [MaxLength(100)]
    public string Location { get; set; } = null!;

    public DateTime DateTime { get; set; }
    
    public ICollection<TrackRace> TrackRaces { get; set; } = null!;
}