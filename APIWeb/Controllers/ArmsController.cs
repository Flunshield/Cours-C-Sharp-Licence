using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace APIWeb.Controllers;

public class ArmsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ArmsController(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    //GetAllWeapon() allows you to consult all the weapons stored in the database.
    [HttpGet]
    [Route("/getAllWeapon")]
    public async Task<ActionResult<List<Arms>>> GetAllWeapon()
    {
        return Ok(await _context.Arms.ToListAsync());
    }

    //GetWeapon(int id) Allows you to view the selected weapon via its name stored in the database.
    [HttpGet]
    [Route("/getWeapon/{id}")]
    public async Task<ActionResult<List<Arms>>> GetWeapon(int id)
    {
        Arms? weaponGet = await _context.Arms.FirstOrDefaultAsync(weaponName => weaponName.Id == id);
        if (weaponGet == null)
        {
            return NotFound("Arm not Found");
        }
        return Ok(weaponGet);
    }

    //CreateWeapon([FromBody] Arms weapon) Allows you to create a weapon and store it in the base. The weapon is created from the body of the request.
    [HttpPost]
    [Route("/addWeapon")]
    public async Task<ActionResult<List<Arms>>> CreateWeapon([FromBody] Arms weapon)
    {
        await _context.Arms.AddAsync(weapon);
        await _context.SaveChangesAsync();
        if (weapon == null)
        {
            return NotFound("The weapon not has been created !");
        }
        return Ok("The weapon has been created ! ");
    }

    //UpdateArms([FromBody] Arms request) allows you to modify the characteristics of a weapon
    [HttpPut]
    [Route("/changeWeapon")]
    public async Task<ActionResult<List<Arms>>> UpdateArms([FromBody] Arms request)
    {
        Arms? weapon = await _context.Arms.FirstOrDefaultAsync(weaponId => weaponId.Id == request.Id);
        if (weapon == null)
        {
            return BadRequest(request);
        }
        weapon.HeroesNameArms = request.HeroesNameArms;
        weapon.EnemysNameArms = request.EnemysNameArms;
        weapon.bonusForce = request.bonusForce;
        weapon.bonusSagesse = request.bonusSagesse;
        weapon.bonusVitality = request.bonusVitality;
        await _context.SaveChangesAsync();
        if (weapon == null)
        {
            return NotFound("The weapon not has been modified !");
        }
        return Ok("The weapon has been modified !");
    }


    [HttpDelete]
    [Route("/deleteWeapon")]
    public async Task<ActionResult<List<Arms>>> DeleteWeapon([FromBody] Arms request)
    {
        Arms? weapon = await _context.Arms.FirstOrDefaultAsync(weaponId => weaponId.Id == request.Id);
        if (weapon == null)
        {
            return NotFound("Hero not Found");
        }
        _context.Remove(weapon);

        await _context.SaveChangesAsync();
        return Ok("The weapon has been deleted !");
    }
}
