namespace API_Counter.Models
{
    public class PlayerPosition
    {
        public int Player_Id { get; set; }
        public Player Player { get; set; }
        public int Position_Id { get; set; }    
        public Position Position { get; set; }
    }
}
