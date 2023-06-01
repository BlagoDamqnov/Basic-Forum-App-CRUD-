using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using static ForumApp.Data.Models.Seeding.PostSeeding;
    public class PostDbContext:DbContext
    {
        public PostDbContext(DbContextOptions options)
        :base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasData(SeedPost());

            base.OnModelCreating(modelBuilder);
        }

    }
}
