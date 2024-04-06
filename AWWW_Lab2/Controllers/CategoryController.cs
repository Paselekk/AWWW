using Microsoft.AspNetCore.Mvc;
using AWWW_Lab2.Models;

namespace AWWW_Lab2.Controllers
{
	public class CategoryController : Controller
	{
		private readonly MyDbContext _dbContext;
		public CategoryController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public IActionResult Index()
		{
			return View(_dbContext.Categories.ToList());
		}
		public IActionResult Add()
		{
			return View();
		}
		public IActionResult Added(string Name) 
		{
			Category category = new Category
			{
				Name = Name,
			};

			_dbContext.Categories.Add(category);
			_dbContext.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
