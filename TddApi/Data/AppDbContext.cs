using Microsoft.EntityFrameworkCore;
using XpTdd.Models;

namespace TddApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    // lager to tables
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Goblin> Goblins { get; set; }
    public DbSet<User> Users { get; set; }
}