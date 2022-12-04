using Microsoft.EntityFrameworkCore;

namespace FRS.Models
{
    public class ContextCS:DbContext
    {
        public ContextCS(DbContextOptions<ContextCS> options) : base(options)
        {

        }
        public DbSet<AdminLogin> AdminLogins { get; set; }

        public DbSet<UserAccount> UserLogins { get; set; }

        public DbSet<AiroPlaneInfo> PlaneInfo { get; set; }

        public DbSet<FlightBooking> flightBookings { get; set; }


    }
}
