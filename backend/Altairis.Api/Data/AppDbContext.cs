
using Microsoft.EntityFrameworkCore;
using Altairis.Api.Models;

namespace Altairis.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Hotel> Hotels => Set<Hotel>();
    public DbSet<RoomType> RoomTypes => Set<RoomType>();
    public DbSet<Inventory> Inventories => Set<Inventory>();
    public DbSet<Reservation> Reservations => Set<Reservation>();
}
