using EventosTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EventosTest.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        //Entities

        public DbSet<User> Users { get; set; }
        public DbSet<Planner> Planners { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<AvatarUser> AvatarUsers { get; set; }
        public DbSet<AvatarPlanner> AvatarPlanners { get; set; }

        

    }
}
