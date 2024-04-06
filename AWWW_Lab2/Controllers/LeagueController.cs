using Microsoft.AspNetCore.Mvc;
using AWWW_Lab2.Models;
using Microsoft.EntityFrameworkCore;

namespace AWWW_Lab2.Controllers
{
	public class LeagueController : Controller
	{
		private readonly MyDbContext _dbContext;
		public LeagueController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			return View(_dbContext.Leagues.ToList());
		}
		public IActionResult Add()
		{
			return View();
		}
		public IActionResult Added(string Name, string Country, int Level) 
		{
			League liga = new()
			{
				Name = Name,
				Country = Country,
				Level = Level
			};
			_dbContext.Leagues.Add(liga);
			_dbContext.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Delete(int id=1)
		{
			League? liga = _dbContext.Leagues.FirstOrDefault(x => x.Id == id);
			if(liga!=null)
			{
				_dbContext.Leagues.Remove(liga);
				_dbContext.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
