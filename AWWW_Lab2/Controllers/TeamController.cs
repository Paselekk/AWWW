using Microsoft.AspNetCore.Mvc;
using AWWW_Lab2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AWWW_Lab2.Controllers
{

	public class TeamController : Controller
	{
		private readonly MyDbContext _dbContext;
		public TeamController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			return View(_dbContext.Teams.ToList());
		}
		public IActionResult Add()
		{
			var tempLeagues = _dbContext.Leagues.ToList();
			var leagues = new List<SelectListItem>();
			foreach (var league in tempLeagues)
			{
				string id = league.Id.ToString();
				string name = league.Name.ToString() + " (" + league.Country + ")";
				leagues.Add(new SelectListItem(name, id));
			}
			ViewBag.leagues = leagues;
			return View();
		}
	}
}
