using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PracaInżynierskaTomaszBaczek.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracaInżynierskaTomaszBaczek.Data
{
    public class ApplicationDbContext : IdentityDbContext<AspNetUsers>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BoardPost> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<BoardPost>().HasMany(x => x.Comments).WithOne(x => x.Boardpost).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
