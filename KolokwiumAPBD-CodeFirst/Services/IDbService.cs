using KolokwiumAPBD_CodeFirst.DTOs;

namespace KolokwiumAPBD_CodeFirst.Services;

public interface IDbService
{
    //Tutaj daje deklaracje metod, których będzie używał controller,
    //a ich definicje będą w DbService.cs, który dziedziczy ten interfejs
    Task<RacerParticipationsDto> GetRacersParticipations(int racerId);
    Task AddParticipations(ParticipationsToAddDto dto);
}