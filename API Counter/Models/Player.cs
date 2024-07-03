namespace API_Counter.Models
{
    public class Player
    {
        public int Player_Id { get; set; }
        public required string Name { get; set; }

        public int Team_Id { get; set; }
        public DateTime DateCreation { get; set; }

        public Team Team { get; set; } // connection one-many -> Every player has just one team

        public ICollection<PlayerPosition> PlayerPositions { get; set; }
        // connection many-many every player has many positions
    }
}
