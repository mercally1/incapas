using Infrastruture.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture;

public class RadioDbContext : DbContext
{
    public RadioDbContext(DbContextOptions<RadioDbContext> options) : base(options)
    {

    }

    public DbSet<Radio> Radios { get; set; }
}
