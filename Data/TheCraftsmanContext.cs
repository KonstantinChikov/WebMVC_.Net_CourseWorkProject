using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class TheCraftsmanContext : IdentityDbContext<User>
    {
        public TheCraftsmanContext(DbContextOptions<TheCraftsmanContext> options) : base(options)
        {
        }

        public override DbSet<User> Users { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Material> Materials { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
