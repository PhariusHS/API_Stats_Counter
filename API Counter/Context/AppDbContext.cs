using API_Counter.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Counter.Context
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        

        
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ManagerTeam> ManagerTeams { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }

    }
}
