using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tournamaker.Areas.Identity.Data;
using tournamaker.Models;

namespace tournamaker.Data;

public class tournamakerContext : IdentityDbContext<tournamakerUser>
{
    public tournamakerContext(DbContextOptions<tournamakerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<tournamaker.Models.Tournoi> Tournoi { get; set; }
}
