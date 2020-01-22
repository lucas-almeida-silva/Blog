using GestaoDeBlog.Data.Mapping;
using GestaoDeBlog.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GestaoDeBlog.Data
{
    public class PostContext : DbContext
    {
        public PostContext(DbContextOptions<PostContext> options) : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostMapping());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Post> Posts { get; set; }

    }
}
