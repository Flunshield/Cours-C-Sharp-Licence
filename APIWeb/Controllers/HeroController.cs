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

    //GetHero(string name)) Allows you to view the selected hero whit name stored in the database.
    [HttpGet]
    [Route("/getHeroes/{name}")]
    public async Task<ActionResult<List<Hero>>> GetHero(string name)
    {
        Hero? heroGet = await _context.Heroes.FirstOrDefaultAsync(heroName => heroName.name == name);
        if (heroGet == null)
        {
            return NotFound("Hero not Found");
        }
        return Ok(heroGet);
    }

    //Allows you to randomly generate an hero and store it in the base. The hero is generated from the AddHeroes() method of the request.
    [HttpPost]
    [Route("/addHero")]
    public async Task<ActionResult<List<Hero>>> Post()
    {
        HeroService addheros = new HeroService();
        var newHeroes = addheros.AddHeroes();
        Hero addNewHeroes = new Hero()
        {
            name = newHeroes.namePlayerGenerate,
            strength = newHeroes.forcePlayer,
            wisdom = newHeroes.sagessePlayer,
            vitality = newHeroes.vitalityPlayer,
            classePlayer = newHeroes.classePlayerGenerate,
            IdWeapon = newHeroes.armsPlayerGenerate
        };
        await _context.Heroes.AddAsync(addNewHeroes);
        await _context.SaveChangesAsync();
        if (addNewHeroes == null)
        {
            return BadRequest();
        }
        return Ok("The " + addNewHeroes.name + " hero has been created ! ");
    }

    //EquipWeapon(long id) allows you to modify one or more elements of an hero.
    [HttpPut]
    [Route("/equipWeapon/{id}")]
    public async Task<ActionResult<List<Hero>>> EquipWeapon(long id)
    {
        Hero? hero = await _context.Heroes.FirstOrDefaultAsync(heroId => heroId.Id == id);
        Weapon? checkArm = await _context.Arms.FirstOrDefaultAsync(bonusArm => bonusArm.Id == hero.IdWeapon);
        if (hero == null)
        {
            return BadRequest(hero);
        }
        hero.IdWeapon = hero.IdWeapon;
        hero.name = hero.name;
        hero.strength = hero.strength + checkArm.bonusStrength;
        hero.vitality = hero.vitality + checkArm.bonusVitality;
        hero.wisdom = hero.wisdom + checkArm.bonusWisdom;
        hero.classePlayer = hero.classePlayer;
        await _context.SaveChangesAsync();
        return Ok("The " + hero.name + " hero has been modified !");
    }

    //RemoveWeapon(long id) allows you to modify one or more elements of an hero.
    [HttpPut]
    [Route("/removeWeaponHero/{id}")]
    public async Task<ActionResult<List<Hero>>> RemoveWeapon(long id)
    {
        Hero? hero = await _context.Heroes.FirstOrDefaultAsync(heroId => heroId.Id == id);
        Weapon? checkArm = await _context.Arms.FirstOrDefaultAsync(bonusArm => bonusArm.Id == hero.IdWeapon);
        if (hero == null)
        {
            return BadRequest(hero);
        }
        hero.IdWeapon = hero.IdWeapon;
        hero.name = hero.name;
        hero.strength = hero.strength - checkArm.bonusStrength;
        hero.vitality = hero.vitality - checkArm.bonusVitality;
        hero.wisdom = hero.wisdom - checkArm.bonusWisdom;
        hero.classePlayer = hero.classePlayer;
        await _context.SaveChangesAsync();
        return Ok("The " + hero.name + " hero has been modified !");
    }

    //eleteHero([FromBody] Hero request) allows you to delete an hero based on its id
    [HttpDelete]
    [Route("/deleteHero")]
    public async Task<ActionResult<List<Hero>>> DeleteHero([FromBody] Hero request)
    {
        Hero? hero = await _context.Heroes.FirstOrDefaultAsync(heroId => heroId.Id == request.Id);
        if (hero == null)
        {
            return NotFound("Hero not Found");
        }
        _context.Remove(hero);

        await _context.SaveChangesAsync();
        return Ok("The " + hero.name + " hero has been deleted !");
    }
}

