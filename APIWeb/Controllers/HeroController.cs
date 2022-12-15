using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;
using APIWeb.Services;
namespace APIWeb.Controllers;

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
    public async Task<ActionResult<List<Hero>>> Post()
    {
        HeroesService addheros = new HeroesService();
        var newHeroes = addheros.AddHeroes();
        Hero addNewHeroes = new Hero()
        {
            name = newHeroes.namePlayerGenerate,
            force = newHeroes.forcePlayer,
            sagesse = newHeroes.sagessePlayer,
            vitality = newHeroes.vitalityPlayer,
            classePlayer = newHeroes.classePlayerGenerate,
            HeroesArms = newHeroes.armsPlayerGenerate
        };
        _context.Heroes.AddAsync(addNewHeroes);
        _context.SaveChanges();

        return Ok(addNewHeroes);
    }

}

