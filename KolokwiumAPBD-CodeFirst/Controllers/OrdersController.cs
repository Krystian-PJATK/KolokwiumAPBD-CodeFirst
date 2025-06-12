using KolokwiumAPBD_CodeFirst.DTOs;
using KolokwiumAPBD_CodeFirst.Exceptions;
using KolokwiumAPBD_CodeFirst.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumAPBD_CodeFirst.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RacersController : ControllerBase
{
    //Tutaj tworzymy endpoint i decydujemy co ma się dziać przy ich obsłudze
    private readonly IDbService _dbService;

    public RacersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{id}/participations")]
    public async Task<IActionResult> GetRacersParticipations(int id)
    {
        try
        {
            var order = await _dbService.GetRacersParticipations(id);
            return Ok(order);
        }
        catch (NotFoundException e)
        {
            return NotFound();
        }
    }
    
    [HttpPut("track-races/participants")]
    public async Task<IActionResult> AddParticipation(ParticipationsToAddDto dto)
    {
        try
        {
            await _dbService.AddParticipations(dto);
            return Ok();
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (ConflictException e)
        {
            return Conflict(e.Message);
        }
    }
}