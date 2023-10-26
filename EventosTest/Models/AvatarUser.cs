namespace EventosTest.Models
{
    public class AvatarUser
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<User> Users { get; set; }
    }
}