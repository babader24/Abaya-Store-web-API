using Abaya_Store.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Abaya_Store.Identity.Configurations;
using System.Collections.Generic;
using System.Text;

namespace Abaya_Store.Identity
{
    public class AbayaStoreDbContext : IdentityDbContext<ApplicationUser>
    {
        public AbayaStoreDbContext(DbContextOptions<AbayaStoreDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
