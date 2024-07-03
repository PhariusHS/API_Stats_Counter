namespace API_Counter.Models
{
    public class Manager
    {

        public int Manager_Id { get; set; } 
        public string Manager_Name { get; set; }

        public ICollection<ManagerTeam> ManagerTeams { get; set; }//Connection many-many every manager has one or more teams
    }
}
