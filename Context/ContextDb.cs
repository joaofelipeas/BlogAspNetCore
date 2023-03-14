using Blog.Models.Configuration;
using Blog.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.Context
{
    public class ContextDb : DbContext
    {
        public DbSet<Content> Contents { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public ContextDb(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ContentConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
        }
    }
}