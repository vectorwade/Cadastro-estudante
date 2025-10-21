using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BalataTest.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<BalataTest.Areas.Models.Student> Student { get; set; } = default!;
    public DbSet<BalataTest.Areas.Models.Premium> Premium { get; set; } = default!;
}
