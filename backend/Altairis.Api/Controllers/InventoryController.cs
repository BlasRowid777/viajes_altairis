using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Altairis.Api.Data;
using Altairis.Api.Models;

namespace Altairis.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
    private readonly AppDbContext _db;
    public InventoryController(AppDbContext db) => _db = db;

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _db.Inventories.ToListAsync());

    [HttpPost]
    public async Task<IActionResult> Create(dynamic data)
    {
        _db.Inventories.Add(data);
        await _db.SaveChangesAsync();
        return Ok(data);
    }
}
