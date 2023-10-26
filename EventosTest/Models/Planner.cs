using System.ComponentModel.DataAnnotations;

namespace EventosTest.Models
{
    public class Planner
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int AvatarPlannerId { get; set; }


        public AvatarPlanner AvatarPlanner { get; set; }
        public IEnumerable<Event> Events { get; set; }

    }
}