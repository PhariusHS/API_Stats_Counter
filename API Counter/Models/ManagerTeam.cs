namespace API_Counter.Models
{
    public class ManagerTeam
    {


        public int Manager_Id { get; set; }
        public Manager Manager { get; set; } // Connection many-many
        // 

        public int Team_Id { get; set; }
        public Team Team { get; set; } // Connection many-many
        //

        public DateTime Asignation_Date { get; set; }

    }
}