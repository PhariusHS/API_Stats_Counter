namespace API_Counter.Models
{
    public class Player
    {
        public int Player_Id { get; set; }
        public required string Name { get; set; }
        public DateTime DateCreation { get; set; }

        public Team Team { get; set; } // connection one-many -> Every player has just one team
    }
}
