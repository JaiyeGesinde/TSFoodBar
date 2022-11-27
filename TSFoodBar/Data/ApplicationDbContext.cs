using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TSFoodBar.Models;

namespace TSFoodBar.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Menu>? Menus { get; set; }

        public DbSet<Starters>? Starters { get; set; }
        public DbSet<Mains>? Mains { get; set; }
        public DbSet<Desserts>? Desserts { get; set; }
        public DbSet<Drinks>? Drinks { get; set; }
        
    }
}