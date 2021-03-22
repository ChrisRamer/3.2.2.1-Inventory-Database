using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
	public class InventoryContext : DbContext
	{
		public DbSet<Game> Games { get; set; }

		public InventoryContext(DbContextOptions options) : base(options) { }
	}
}