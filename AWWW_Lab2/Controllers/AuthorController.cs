using Microsoft.AspNetCore.Mvc;
using AWWW_Lab2.Models;

namespace AWWW_Lab2.Controllers
{
	public class AuthorController : Controller
	{
		private readonly MyDbContext _dbContext;
		public AuthorController(MyDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IActionResult Index()
		{
			return View(_dbContext.Authors.ToList());
		}

		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Added(string FirstName, string LastName)
		{
			Author author = new Author
			{
				FirstName = FirstName,
				LastName = LastName
			};
			_dbContext.Authors.Add(author);
			_dbContext.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
