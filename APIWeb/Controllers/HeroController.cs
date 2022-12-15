﻿using Microsoft.AspNetCore.Mvc;
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
        await _context.SaveChangesAsync();
        if (addNewHeroes == null)
        {
            return BadRequest();
        }
        return Ok("The " + addNewHeroes.name + " hero has been created ! ");
    }

    //UpdateHero([FromBody] Enemys request) allows you to modify one or more elements of an hero by its id sent from the body.
    [HttpPut]
    [Route("/changeHeroFeature")]
    public async Task<ActionResult<List<Hero>>> UpdateHero([FromBody] Hero request)
    {
        Hero? hero = await _context.Heroes.FirstOrDefaultAsync(heroId => heroId.Id == request.Id);
        if (hero == null)
        {
            return BadRequest(request);
        }
        hero.HeroesArms = request.HeroesArms;
        hero.name = request.name;
        hero.force = request.force;
        hero.vitality = request.vitality;
        hero.sagesse = request.sagesse;
        hero.classePlayer = request.classePlayer;
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

    // Ne fonctionne pas
    //[HttpPut]
    //[Route("/changeHeroFeature/{id}")]
    //public async Task<ActionResult<List<Hero>>> EquipWeapon(int id)
    //{
    //    Hero hero = await _context.Heroes.FirstOrDefaultAsync(heroId => heroId.Id == id);
    //    ArmsController checkArm = new ArmsController();

    //    int IdWeapon = 0;

    //    switch (hero.HeroesArms)
    //    {
    //        case "Sword":
    //            IdWeapon = 1;
    //            break;

    //        case "Scèptre":
    //            IdWeapon = 2;
    //            break;

    //        case "Dagger":
    //            IdWeapon = 3;
    //            break;
    //    }

    //    ArmsController weapon = checkArm.GetWeapon(IdWeapon);
    //    if (hero == null)
    //    {
    //        return BadRequest("Hero not Found");
    //    }

    //    HeroesService newFeature = HeroesService.AddFeatureWeaponHeroes(hero, weapon);
    //    return Ok(hero);
    //}

}

