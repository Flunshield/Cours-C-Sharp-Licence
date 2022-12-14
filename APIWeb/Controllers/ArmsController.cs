using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Controllers;

public class ArmsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ArmsController(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    public async Task<ActionResult<List<Hero>>> Get()
    {
        return  Ok(await _context.Heroes.ToListAsync());
    }
}


