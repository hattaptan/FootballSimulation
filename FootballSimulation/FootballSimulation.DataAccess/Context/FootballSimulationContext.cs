using FootballSimulation.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballSimulation.DataAccess.Context
{
    public class FootballSimulationContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=FS_DB;Trusted_Connection=True;");
        }

       



        public DbSet<Fixture> Fixtures { get; set; }
        public DbSet<Match> Matchs { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Week> Weeks { get; set; }


        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fixture>()
               .HasOne(p => p.OpponentTeam).WithOne().OnDelete(DeleteBehavior.NoAction);
           

            modelBuilder.Entity<Fixture>()
               .HasOne(p => p.Week).WithOne().OnDelete(DeleteBehavior.NoAction); 
            modelBuilder.Entity<Fixture>()
               .HasOne(p => p.HomeTeam).WithOne().OnDelete(DeleteBehavior.NoAction); 
        }
        #endregion

    }
}
