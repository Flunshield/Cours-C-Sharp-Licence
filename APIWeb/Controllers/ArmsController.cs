using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Controllers;

public class ArmsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public ArmsController(ApplicationDbContext dbContext)
    {
        _context = dbContext;
    }

    //GetAllArms() allows you to consult all the weapons stored in the database.
    [HttpGet]
    [Route("/getAllArms")]
    public async Task<ActionResult<List<Arms>>> GetAllArms()
    {
        return Ok(await _context.Heroes.ToListAsync());
    }

    //Put this method as a comment so as not to crash Swagger.
    //GetArm(int id) Allows you to view the selected weapon via its name stored in the database.
    [HttpGet("{id}")]
    [Route("/getArms/{id}")]
    public async Task<ActionResult<List<Arms>>> GetArm(int id)
    {
        Arms armsGet = await _context.Arms.FirstOrDefaultAsync(armsName => armsName.Id == id);
        if (armsGet == null)
        {
            return NotFound("Arm not Found");
        }
        return Ok(armsGet);
    }

    //CreateArms([FromBody] Arms arms) Allows you to create a weapon and store it in the base. The weapon is created from the body of the request.
    [HttpPost]
    [Route("/addArms")]
    public async Task<ActionResult<List<Arms>>> CreateArms([FromBody] Arms arms)
    {
        await _context.Arms.AddAsync(arms);
        _context.SaveChanges();

        return Ok(arms);
    }
}


