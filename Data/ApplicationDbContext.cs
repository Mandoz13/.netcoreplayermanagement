using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using PlayerManagement.Models;

namespace PlayerManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PlayerManagement.Models.Player> Player { get; set; }
        public DbSet<PlayerManagement.Models.Team> Team { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                     

            modelBuilder.Entity<Player>()
                .HasOne(t => t.Team)
                .WithMany(p => p.Players)
                .HasForeignKey(t => t.TeamId);

            modelBuilder.Entity<Team>()
               .HasIndex(t => t.Name)
               .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
