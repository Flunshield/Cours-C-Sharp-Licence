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
    [Route("/getEnemys/{name}")]
    public async Task<ActionResult<List<Enemys>>> GetEnemys(string name)
    {
        Enemys enemysGet = await _context.Enemys.FirstOrDefaultAsync(enemysName => enemysName.name == name);
        if (enemysGet == null)
        {
            return NotFound("Enemy not Found");
        }
        return Ok(enemysGet);
    }

    //Allows you to randomly generate an enemy and store it in the base. The enemy is generated from the AddEnemys() method of the request.
    [HttpPost]
    [Route("/addEnemys")]
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
            EnemysArms = newEnemys.armsPlayerGenerate
        };
        await _context.Enemys.AddAsync(addNewEnemys);
        await _context.SaveChangesAsync();
        return Ok(addNewEnemys);
    }

    //UpdateEnemy([FromBody] Enemys request) allows you to modify one or more elements of an enemy by its id sent from the body.
    [HttpPut]
    [Route("/changeEnemysFeature")]
    public async Task<ActionResult<List<Enemys>>> UpdateEnemy([FromBody] Enemys request)
    {
        Enemys enemy = await _context.Enemys.FirstOrDefaultAsync(enemyId => enemyId.Id == request.Id);
        if (enemy == null)
        {
            return BadRequest(request);
        }
        enemy.EnemysArms = request.EnemysArms;
        enemy.name = request.name;
        enemy.force = request.force;
        enemy.vitality = request.vitality;
        enemy.sagesse = request.sagesse;
        enemy.classePlayer = request.classePlayer;
        await _context.SaveChangesAsync();
        return Ok(enemy);
    }
}

