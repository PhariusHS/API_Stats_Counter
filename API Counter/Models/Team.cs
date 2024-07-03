namespace API_Counter.Models
{
    public class Team
    {
        public int Team_Id { get; set; }
        public string Team_name { get; set; }
        public string Team_desc { get; set; }
    
        public ICollection<Player> Players { get; set; } //Connection many-one Every team has multiple players

    }
}
