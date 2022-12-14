using Microsoft.AspNetCore.Mvc;
using APIWeb.Entities;

namespace APIWeb.Controllers;

public class EnemysController : ControllerBase
{
    private string[] Enemys = new[]
    {
        "Batman", "SuperMan", "Flash", "CoolMan", "MildMan", "JulienMan"
    };

    [HttpGet]
    public IEnumerable<Enemys> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Enemys
        {
        })
        .ToArray();
    }
}

