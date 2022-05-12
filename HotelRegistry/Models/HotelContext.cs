using Microsoft.EntityFrameworkCore;

namespace HotelRegistry.Models
{
	public class HotelContext : DbContext
	{
		public DbSet<Hotel> Hotels { get; set; }

		public HotelContext(DbContextOptions<HotelContext> options)
			: base(options)
		{
			Database.EnsureCreated();
		}
	}
}
