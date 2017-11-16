using CalendarApp.DbModels.Tables;
using System.Data.Entity;

namespace CalendarApp.DbModels
{
    public class EfContext : ApplicationDbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
