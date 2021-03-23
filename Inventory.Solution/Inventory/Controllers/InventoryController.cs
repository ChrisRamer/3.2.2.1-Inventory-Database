using Microsoft.AspNetCore.Mvc;
using Inventory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Controllers
{
	public class InventoryController : Controller
	{
		private readonly InventoryContext _db;

		public InventoryController(InventoryContext db)
		{
			_db = db;
		}

		public ActionResult Index()
		{
			List<Game> model = _db.Games.ToList();
			return View(model);
		}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Game game)
		{
			_db.Games.Add(game);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		public ActionResult Details(int id)
		{
			Game thisGame = _db.Games.FirstOrDefault(game => game.GameId == id);
			return View(thisGame);
		}

		public ActionResult Delete(int id)
		{
			Game thisGame = _db.Games.FirstOrDefault(game => game.GameId == id);
			return View(thisGame);
		}

		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			Game thisGame = _db.Games.FirstOrDefault(game => game.GameId == id);
			_db.Remove(thisGame);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}