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
                .HasForeignKey(m => m.Manager_Id);
            modelBuilder.Entity<ManagerTeam>()
                .HasOne(t => t.Team)
                .WithMany(mt => mt.TeamManagers)
                .HasForeignKey(t => t.Team_Id);

            modelBuilder.Entity<PlayerPosition>()
                .HasKey(pp => new { pp.Player_Id, pp.Position_Id });
            modelBuilder.Entity<PlayerPosition>()
                .HasOne(p => p.Player)
                .WithMany(pp  => pp.PlayerPositions)
                .HasForeignKey(p =>  p.Player_Id);
            modelBuilder.Entity<PlayerPosition>()
                .HasOne(p => p.Position)
                .WithMany(pp => pp.PlayersPositions)
                .HasForeignKey(p => p.Position_Id);


            // Add initial seeding data
            modelBuilder.Entity<Team>().HasData(
                new Team { Team_Id = 1, Team_name = "Syrako Rugby", Team_desc = "Syrako rugby club from Siracusa" }
            );

            modelBuilder.Entity<Position>().HasData(
                new Position { Position_Id = 1, Position_Name = "PilarI" },
                new Position { Position_Id = 2, Position_Name = "Hooker" },
                new Position { Position_Id = 3, Position_Name = "PilarD" },
                new Position { Position_Id = 4, Position_Name = "SegundaLineaI" },
                new Position { Position_Id = 5, Position_Name = "SegundaLineaD" },
                new Position { Position_Id = 6, Position_Name = "AlaI" },
                new Position { Position_Id = 7, Position_Name = "AlaD" },
                new Position { Position_Id = 8, Position_Name = "Octavo" },
                new Position { Position_Id = 9, Position_Name = "MedioScrum" },
                new Position { Position_Id = 10, Position_Name = "MedioApertura" },
                new Position { Position_Id = 11, Position_Name = "Wing" }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Player_Id = 1,
                    Name = "Luca Ponteprimo",
                    BirthDate = new DateTime(2004, 12, 20),
                    Team_Id = 1
                }
            );

            modelBuilder.Entity<PlayerPosition>().HasData(
                new PlayerPosition { Player_Id = 1, Position_Id = 9 }
            );

            modelBuilder.Entity<Manager>().HasData(
                new Manager { Manager_Id = 1, Manager_Name = "Manager A" }
            );

            modelBuilder.Entity<ManagerTeam>().HasData(
                new ManagerTeam
                {
                    Manager_Id = 1,
                    Team_Id = 1,
                    Asignation_Date = DateTime.UtcNow
                }
            );
        }
    }
}

        }
    }
}
