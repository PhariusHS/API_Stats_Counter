using API_Counter.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace API_Counter.Context
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        

        
        }

       //Datacontext
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ManagerTeam> ManagerTeams { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }



        //Many to Many realtionship

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Manager <-> Teams relationship
            modelBuilder.Entity<ManagerTeam>()
                .HasKey(mt => new {mt.Manager_Id, mt.Team_Id});
            modelBuilder.Entity<ManagerTeam>()
                .HasOne(m => m.Manager)
                .WithMany(mt => mt.ManagerTeams)
                .HasForeignKey(t => t.Team_Id);

        }
    }
}
