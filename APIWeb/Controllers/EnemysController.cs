using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;
using APIWeb.Services;
namespace APIWeb.Controllers;

[ApiController]
[Route("[Controller]")]
public class EnemysController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EnemysController(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    [HttpGet]
    [Route("/getEnemys")]
    public async Task<ActionResult<List<Enemys>>> Get()
    {
        return Ok(await _context.Enemys.ToListAsync());
    }

    [HttpPost]
    [Route("/addEnemys")]
    public async Task<ActionResult<List<Enemys>>> Post()
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
        _context.Enemys.AddAsync(addNewEnemys);
        _context.SaveChanges();

        return Ok(addNewEnemys);
    }

}

