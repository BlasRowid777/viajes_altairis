using System;

namespace Altairis.Api.Models;
public class Inventory
{
    public int Id { get; set; }
    public int RoomTypeId { get; set; }
    public DateTime Fecha { get; set; }
    public int CantidadDisponible { get; set; }
}
