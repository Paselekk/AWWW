using Microsoft.AspNetCore.Mvc;
using AWWW_Lab2.Models;

namespace AWWW_Lab2.Controllers
{
	public class PositionController : Controller
	{
		private readonly MyDbContext _dbContext;
		public PositionController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			return View(_dbContext.Positions.ToList());
		}
		public IActionResult Add()
		{
			return View();
		}
		public IActionResult Added(string Name)
		{
			Position pozycja = new Position
			{
				Name=Name
			};
			_dbContext.Positions.Add(pozycja);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			Position? pozycja = _dbContext.Positions.FirstOrDefault(x=> x.Id == id);
			if (pozycja != null)
			{
				_dbContext.Remove(pozycja);
				_dbContext.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
