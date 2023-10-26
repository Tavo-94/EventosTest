namespace EventosTest.Models
{
    public class Event
    {

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EventDate { get; set; }
        public string PlannerEmail { get; set; }


        //nav
        public Planner Planner { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<EventToUsers> EventToUsers { get; set; }

    }
}