using KolokwiumAPBD_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumAPBD_CodeFirst.Data;

public class DatabaseContext : DbContext
{
    //Tutaj daje dane, jakimi będzie wypełniona baza danych za pomocą dotnet EF
    public DbSet<Racer> Racer { get; set; }
    public DbSet<Track> Track { get; set; }
    public DbSet<Race> Race { get; set; }
    public DbSet<RaceParticipation> RaceParticipations { get; set; }
    public DbSet<TrackRace> TrackRace { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Racer>().HasData(new List<Racer>()
        {
            new Racer() { RacerId = 1, FirstName = "Lewis", LastName = "Hamilton" }
        });
        
        modelBuilder.Entity<Track>().HasData(new List<Track>()
        {
            new Track() { TrackId = 1, Name = "Silverstone Circuit", LengthInKm = 5.89f},
            new Track() { TrackId = 2, Name = "Monaco Circuit", LengthInKm = 3.34f}
        });
        
        modelBuilder.Entity<Race>().HasData(new List<Race>()
        {
            new Race() { RaceId = 1, Name = "British Grand Prix", Location = "Silverstone, UK", DateTime = DateTime.Parse("2025-07-14")},
            new Race() { RaceId = 2, Name = "Monaco Grand Prix", Location = "Monte Carlo, Monaco", DateTime = DateTime.Parse("2025-05-25")}
        });
        
        modelBuilder.Entity<TrackRace>().HasData(new List<TrackRace>()
        {
            new TrackRace() { TrackRaceId = 1, RaceId = 1, TrackId = 1, Laps = 52},
            new TrackRace() { TrackRaceId = 2, RaceId = 2, TrackId = 2, Laps = 78}
        });
        
        modelBuilder.Entity<RaceParticipation>().HasData(new List<RaceParticipation>()
        {
            new RaceParticipation() { TrackRaceId = 1, RacerId = 1, FinishTimeInSeconds = 5460, Position = 1},
            new RaceParticipation() { TrackRaceId = 2, RacerId = 1, FinishTimeInSeconds = 6300, Position = 2}
        });
    }
}