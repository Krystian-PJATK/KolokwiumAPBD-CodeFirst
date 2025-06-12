using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumAPBD_CodeFirst.Models;

[Table("Track")]
public class Track
{
    [Key]
    public int TrackId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    
    [Column(TypeName = "decimal(5, 2)")]
    public float LengthInKm { get; set; }
    
    
    public ICollection<TrackRace> TrackRaces { get; set; } = null!;
}