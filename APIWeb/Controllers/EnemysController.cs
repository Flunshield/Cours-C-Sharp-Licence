using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;
using APIWeb.Services;
namespace APIWeb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EnemysController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EnemysController(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    //GetAllEnemys() allows you to consult all enemys stored in the database.
    [HttpGet]
    [Route("/getAllEnemys")]
    public async Task<ActionResult<List<Enemys>>> GetAllEnemys()
    {
        return Ok(await _context.Enemys.ToListAsync());
    }

    //GetEnemys(string name) Allows you to view the selected enemy whit name stored in the database.
    [HttpGet]
    [Route("/getEnemy/{name}")]
    public async Task<ActionResult<List<Enemys>>> GetEnemys(string name)
    {
        Enemys? enemysGet = await _context.Enemys.FirstOrDefaultAsync(enemysName => enemysName.name == name);
        if (enemysGet == null)
        {
            return NotFound("Enemy not Found");
        }
        return Ok(enemysGet);
    }

    //Allows you to randomly generate an enemy and store it in the base. The enemy is generated from the AddEnemys() method of the request.
    [HttpPost]
    [Route("/addEnemy")]
    public async Task<ActionResult<List<Enemys>>> PostEnemy()
    {
        EnemysService addenemys = new EnemysService();
        var newEnemys = addenemys.AddEnemys();
        Enemys addNewEnemys = new Enemys()
        {
            name = newEnemys.namePlayerGenerate,
            force = newEnemys.forcePlayer,
            sagesse = newEnemys.sagessePlayer,
            vitality = newEnemys.vitalityPlayer,
            classePlayer = newEnemys.classePlayerGenerate,
            IdArms = newEnemys.armsPlayerGenerate
        };
        await _context.Enemys.AddAsync(addNewEnemys);
        await _context.SaveChangesAsync();
        return Ok("The " + addNewEnemys.name + "enemy was created");
    }

    //EquipWeapon(long id) allows you to modify one or more elements of an hero.
    [HttpPut]
    [Route("/equipWeaponEnemy/{id}")]
    public async Task<ActionResult<List<Enemys>>> EquipWeapon(long id)
    {
        Enemys? enemy = await _context.Enemys.FirstOrDefaultAsync(enemyId => enemyId.Id == id);
        Arms? checkArm = await _context.Arms.FirstOrDefaultAsync(bonusArm => bonusArm.Id == enemy.IdArms);
        if (enemy == null)
        {
            return BadRequest(enemy);
        }
        enemy.IdArms = enemy.IdArms;
        enemy.name = enemy.name;
        enemy.force = enemy.force + checkArm.bonusForce;
        enemy.vitality = enemy.vitality + checkArm.bonusVitality;
        enemy.sagesse = enemy.sagesse + checkArm.bonusSagesse;
        enemy.classePlayer = enemy.classePlayer;
        await _context.SaveChangesAsync();
        return Ok("The " + enemy.name + " enemy has been modified !");
    }

    //RemoveWeapon(long id) allows you to modify one or more elements of an hero.
    [HttpPut]
    [Route("/removeWeaponEnemy/{id}")]
    public async Task<ActionResult<List<Enemys>>> RemoveWeapon(long id)
    {
        Enemys? enemy = await _context.Enemys.FirstOrDefaultAsync(enemyId => enemyId.Id == id);
        Arms? checkArm = await _context.Arms.FirstOrDefaultAsync(bonusArm => bonusArm.Id == enemy.IdArms);
        if (enemy == null)
        {
            return BadRequest(enemy);
        }
        enemy.IdArms = enemy.IdArms;
        enemy.name = enemy.name;
        enemy.force = enemy.force - checkArm.bonusForce;
        enemy.vitality = enemy.vitality - checkArm.bonusVitality;
        enemy.sagesse = enemy.sagesse - checkArm.bonusSagesse;
        enemy.classePlayer = enemy.classePlayer;
        await _context.SaveChangesAsync();
        return Ok("The " + enemy.name + " enemy has been modified !");
    }

    //DeleteEnemy([FromBody] Enemys request) allows you to delete an enemy based on its id
    [HttpDelete]
    [Route("/deleteEnemy")]
    public async Task<ActionResult<List<Enemys>>> DeleteEnemy([FromBody] Enemys request)
    {
        Enemys? enemy = await _context.Enemys.FirstOrDefaultAsync(enemyId => enemyId.Id == request.Id);
        if (enemy == null)
        {
            return BadRequest(request);
        }
        _context.Remove(enemy);

        await _context.SaveChangesAsync();
        return Ok("The " + enemy.name + " enemy has been deleted !");
    }
}

