namespace TheTeknoShop.Data
{
    using Models;

    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

    public class TheTeknoShopDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public TheTeknoShopDbContext(DbContextOptions<TheTeknoShopDbContext> options)
            : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}