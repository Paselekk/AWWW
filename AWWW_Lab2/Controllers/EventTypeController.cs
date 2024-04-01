using Microsoft.AspNetCore.Mvc;
using AWWW_Lab2.Models;
namespace AWWW_Lab2.Controllers
{
    public class EventTypeController : Controller
    {

        private readonly MyDbContext _dbContext;


        public EventTypeController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View(_dbContext.EventTypes.ToList());
        }

		public IActionResult Add()
		{
			return View();
		}

		public IActionResult Added(string name)
		{
            EventType eventType = new()
            {
                Name = name,
            };

            _dbContext.EventTypes.Add(eventType);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
		}
	}
}
