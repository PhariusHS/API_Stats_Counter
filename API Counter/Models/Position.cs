    namespace API_Counter.Models
    {
        public class Position
        {
            public int Position_Id { get; set; }

            public string Position_Name { get; set; }

            public ICollection<PlayerPosition> PlayersPositions { get; set; }

        }
    }
