using KolokwiumAPBD_CodeFirst.DTOs;

namespace KolokwiumAPBD_CodeFirst.Services;

public interface IDbService
{
    //Tutaj daje deklaracje metod, których będzie używał controller,
    //a ich definicje będą w DbService.cs, który dziedziczy ten interfejs
    Task<OrderDto> GetOrderById(int orderId);
    Task FulfillOrder(int orderId, FulfillOrderDto dto);
}