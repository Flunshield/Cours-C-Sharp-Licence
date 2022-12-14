using APIWeb.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIWeb.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Hero> Heroes { get; set; } //le nom de la propriété sera le nom de la table en bdd
        public DbSet<Enemys> Enemys { get; set; } //le nom de la propriété sera le nom de la table en bdd
        public DbSet<Arms> Arms { get; set; } //le nom de la propriété sera le nom de la table en bdd


    }
}
