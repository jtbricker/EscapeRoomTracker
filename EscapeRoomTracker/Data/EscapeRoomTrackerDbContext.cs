using EscapeRoomTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace EscapeRoomTracker.Data
{
    public class EscapeRoomTrackerDbContext : DbContext
    {
        public EscapeRoomTrackerDbContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<EscapeRoom> EscapeRooms { get; set; }
    }
}
