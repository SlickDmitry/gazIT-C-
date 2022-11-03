using Microsoft.EntityFrameworkCore;



namespace BlueYonder.Flights.Models
 {
    public class FlightsContext : DbContext
    {
        public FlightsContext(DbContextOptions<FlightsContext> options) : base(options)
        {
            private readonly FlightsContext _context;

            public FlightsController(FlightsContext context)
            {
                _context = context;
            }
        }

        public DbSet<Flight> Flights { get; set; }

    }

 }