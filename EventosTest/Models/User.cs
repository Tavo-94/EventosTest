using System.ComponentModel.DataAnnotations;

namespace EventosTest.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int AvatarUserId { get; set; }

        public AvatarUser AvatarUser { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<EventToUsers> EventToUsers { get; set; }

    }
}
