using System;

namespace Altairis.Api.Models;
public class Reservation
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public int RoomTypeId { get; set; }
    public DateTime Fecha { get; set; }
    public int Cantidad { get; set; }
    public string NombreCliente { get; set; } = "";
}
