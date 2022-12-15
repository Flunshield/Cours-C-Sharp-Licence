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
    public async Task<ActionResult<List<Enemy>>> GetAllEnemys()
    {
        return Ok(await _context.Enemys.ToListAsync());
    }

    //GetEnemys(string name) Allows you to view the selected enemy whit name stored in the database.
    [HttpGet]
    [Route("/getEnemy/{name}")]
    public async Task<ActionResult<List<Enemy>>> GetEnemys(string name)
    {
        Enemy? enemysGet = await _context.Enemys.FirstOrDefaultAsync(enemysName => enemysName.name == name);
        if (enemysGet == null)
        {
            return NotFound("Enemy not Found");
        }
        return Ok(enemysGet);
    }

    //Allows you to randomly generate an enemy and store it in the base. The enemy is generated from the AddEnemys() method of the request.
    [HttpPost]
    [Route("/addEnemy")]
    public async Task<ActionResult<List<Enemy>>> PostEnemy()
    {
        EnemyService addenemys = new EnemyService();
        var newEnemys = addenemys.AddEnemys();
        Enemy addNewEnemys = new Enemy()
        {
            name = newEnemys.namePlayerGenerate,
            strength = newEnemys.forcePlayer,
            wisdom = newEnemys.sagessePlayer,
            vitality = newEnemys.vitalityPlayer,
            classePlayer = newEnemys.classePlayerGenerate,
            IdWeapon = newEnemys.armsPlayerGenerate
        };
        await _context.Enemys.AddAsync(addNewEnemys);
        await _context.SaveChangesAsync();
        return Ok("The " + addNewEnemys.name + "enemy was created");
    }

    //EquipWeapon(long id) allows you to modify one or more elements of an hero.
    [HttpPut]
    [Route("/equipWeaponEnemy/{id}")]
    public async Task<ActionResult<List<Enemy>>> EquipWeapon(long id)
    {
        Enemy? enemy = await _context.Enemys.FirstOrDefaultAsync(enemyId => enemyId.Id == id);
        Weapon? checkArm = await _context.Arms.FirstOrDefaultAsync(bonusArm => bonusArm.Id == enemy.IdWeapon);
        if (enemy == null)
        {
            return BadRequest(enemy);
        }
        enemy.IdWeapon = enemy.IdWeapon;
        enemy.name = enemy.name;
        enemy.strength = enemy.strength + checkArm.bonusStrength;
        enemy.vitality = enemy.vitality + checkArm.bonusVitality;
        enemy.wisdom = enemy.wisdom + checkArm.bonusWisdom;
        enemy.classePlayer = enemy.classePlayer;
        await _context.SaveChangesAsync();
        return Ok("The " + enemy.name + " enemy has been modified ! you win +" + checkArm.bonusStrength + " strong +" + checkArm.bonusVitality + " vitality +" + checkArm.bonusWisdom + " sagesse");
    }

    //RemoveWeapon(long id) allows you to modify one or more elements of an hero.
    [HttpPut]
    [Route("/removeWeaponEnemy/{id}")]
    public async Task<ActionResult<List<Enemy>>> RemoveWeapon(long id)
    {
        Enemy? enemy = await _context.Enemys.FirstOrDefaultAsync(enemyId => enemyId.Id == id);
        Weapon? checkArm = await _context.Arms.FirstOrDefaultAsync(bonusArm => bonusArm.Id == enemy.IdWeapon);
        if (enemy == null)
        {
            return BadRequest(enemy);
        }
        enemy.IdWeapon = enemy.IdWeapon;
        enemy.name = enemy.name;
        enemy.strength = enemy.strength - checkArm.bonusStrength;
        enemy.vitality = enemy.vitality - checkArm.bonusVitality;
        enemy.wisdom = enemy.wisdom - checkArm.bonusWisdom;
        enemy.classePlayer = enemy.classePlayer;
        await _context.SaveChangesAsync();
        return Ok("The " + enemy.name + " enemy has been modified ! you won -" + checkArm.bonusStrength + " strong -" + checkArm.bonusVitality + " vitality -" + checkArm.bonusWisdom + " sagesse -");
    }

    //DeleteEnemy([FromBody] Enemys request) allows you to delete an enemy based on its id
    [HttpDelete]
    [Route("/deleteEnemy")]
    public async Task<ActionResult<List<Enemy>>> DeleteEnemy([FromBody] Enemy request)
    {
        Enemy? enemy = await _context.Enemys.FirstOrDefaultAsync(enemyId => enemyId.Id == request.Id);
        if (enemy == null)
        {
            return BadRequest(request);
        }
        _context.Remove(enemy);

        await _context.SaveChangesAsync();
        return Ok("The " + enemy.name + " enemy has been deleted !");
    }
}

