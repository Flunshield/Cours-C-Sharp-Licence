using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;
using System.Web;
namespace APIWeb.Controllers;
using System.Net;
using System.Collections.Specialized;
using APIWeb.Services;

[ApiController]
[Route("[Controller]")]
public class HeroController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public HeroController(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }
    [HttpGet]
    [Route("/getHeroes")]
    public async Task<ActionResult<List<Hero>>> Get()
    {
        return  Ok(await _context.Heroes.ToListAsync());
    }

    [HttpPost]
    [Route("/addHeroes")]
    public void Post()
    {
        HeroesService addheros = new HeroesService();
        addheros.AddHeroes();
    }
}

