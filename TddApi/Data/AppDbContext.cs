using Microsoft.EntityFrameworkCore;
using XpTdd.Models;

namespace TddApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    // Makes two Tables in Database. was planning making more but for assignment it was not needed hence weapons and players have no refs.
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Goblin> Goblins { get; set; }
    public DbSet<User> Users { get; set; }
}