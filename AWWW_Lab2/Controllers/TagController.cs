using Microsoft.AspNetCore.Mvc;
using AWWW_Lab2.Models;

namespace AWWW_Lab2.Controllers
{
	public class TagController : Controller
	{
		private readonly MyDbContext _dbContext;
		public TagController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			return View(_dbContext.Tags.ToList());
		}
		public IActionResult Add()
		{
			return View();
		}
		public IActionResult Added(string Name)
		{
			Tag tag = new Tag
			{
				Name = Name
			};
			_dbContext.Tags.Add(tag);
			_dbContext.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
