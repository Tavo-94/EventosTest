using System.ComponentModel.DataAnnotations;

namespace EventosTest.Models
{
    public class EventToUsers
    {
        [Key]
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string EventEmail { get; set; }

        public User User { get; set; }
        public Event Event { get; set; }
    }
}
