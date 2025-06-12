namespace KolokwiumAPBD_CodeFirst.DTOs;

public class RacerParticipationsDto
{
    public int RacerId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public List<ParticipationsDto> Participations { get; set; } = null!;
}

public class RaceDto
{
    public string name { get; set; } = null!;
    public string location { get; set; } = null!;
    public DateTime date { get; set; }
}

public class TrackDto
{
    public string name { get; set; } = null!;
    public float lengthInKm { get; set; }
}

public class ParticipationsDto
{
    public RaceDto Race { get; set; } = null!;
    public TrackDto Track { get; set; } = null!;
    public int laps { get; set; }
    public int FinishtimeInSeconds { get; set; }
    public int position { get; set; }
}