namespace EventosTest.Models
{
    public class AvatarPlanner
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }

        public ICollection<Planner> Planners { get; set;}
    }
}