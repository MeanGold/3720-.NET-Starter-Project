using Microsoft.EntityFrameworkCore;
using WebApp1.Data.Entities;
namespace WebApp1.Data;

public class TigerTixContext : DbContext
{
    public required DbSet<User> Users { get; set; }

    public required DbSet<Event> Events { get; set; }

    public required DbSet<Ticket> Tickets { get; set; }

    private readonly IConfiguration _config;

    public TigerTixContext(IConfiguration config)
    {
        _config = config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
    }
}

