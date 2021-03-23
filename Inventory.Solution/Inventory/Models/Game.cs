using System;

namespace Inventory.Models
{
	public class Game
	{
		public int GameId { get; set; }
		public string Name { get; set; }
		public DateTime ReleaseDate { get; set; }
		public string Developer { get; set; }
	}
}