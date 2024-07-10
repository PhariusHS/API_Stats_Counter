using API_Counter.Context;
using API_Counter.Models;

namespace API_Counter
{
    public class Seed
    {
        private readonly AppDbContext appDbContext;

        public Seed(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }



        public void seedAppDbContext()


        {
            if (!appDbContext.PlayerPositions.Any())
            {
                var playerPositions = new List<PlayerPosition>()
                {
                    new PlayerPosition()
                    {
                        Player = new Player()
                        {
                            Name = "Luca Ponteprimo",
                            BirthDate = new DateTime(2004,12,20),
                            Team = new Team()
                            
                        }
                    }

                };
            }
        }
    }
}
