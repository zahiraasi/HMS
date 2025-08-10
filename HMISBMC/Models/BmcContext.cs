using Microsoft.EntityFrameworkCore;

namespace HMISBMC.Models;

public class BmcContext : DbContext
{
    public BmcContext(DbContextOptions<BmcContext> options) : base(options)
    {
    }

    public DbSet<Patient> Patients => Set<Patient>();
}

public class Patient
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
