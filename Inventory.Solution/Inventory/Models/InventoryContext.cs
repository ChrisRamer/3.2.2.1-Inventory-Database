using Microsoft.EntityFrameworkCore;

namespace Inventory.Models
{
	public class InventoryContext : DbContext
	{
		public DbSet<Inventory> Inventory { get; set; }

		public InventoryContext(DbContextOptions options) : base(options) { }
	}
}