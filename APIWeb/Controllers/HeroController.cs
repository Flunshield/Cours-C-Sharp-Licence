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

    //GetAllHeroes() allows you to consult all heroes stored in the database.
    [HttpGet]
    [Route("/getAllHeroes")]
    public async Task<ActionResult<List<Hero>>> GetAllHeroes()
    {
        return  Ok(await _context.Heroes.ToListAsync());
    }

    //Put this method as a comment so as not to crash Swagger.
    //GetHero(string name)) Allows you to view the selected hero whit name stored in the database.
    [HttpGet("{name}")]
    [Route("/getHeroes/{name}")]
    public async Task<ActionResult<List<Hero>>> GetHero(string name)
    {
        Hero heroGet = await _context.Heroes.FirstOrDefaultAsync(heroName => heroName.name == name);
        if (heroGet == null)
        {
            return NotFound("Enemy not Found");
        }
        return Ok(heroGet);
    }

    //Allows you to randomly generate an hero and store it in the base. The hero is generated from the AddHeroes() method of the request.
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
        await _context.Heroes.AddAsync(addNewHeroes);
        _context.SaveChanges();

        return Ok(addNewHeroes);
    }

}

