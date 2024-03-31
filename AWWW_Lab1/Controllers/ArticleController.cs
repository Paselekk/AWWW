using Microsoft.AspNetCore.Mvc;
using AWWW_Lab1.Models;

namespace AWWW_Lab1.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index(int id=1)
        {
            var articles =new List<Article>
            {
                new Article {
                Id= 1,
                Title = "Artukuł 1",
                Content = "Lorem ipsum...",
                CreationDate = DateTime.Now
                },
                new Article {
                Id= 2,
                Title = "Artukuł 2",
                Content = "Lorem ipsum...",
                CreationDate = DateTime.Now
                },
                new Article {
                Id= 3,
                Title = "Artukuł 3",
                Content = "Lorem ipsum...",
                CreationDate = DateTime.Now
                }
            };
            return View(articles[id-1]);
        }
    }
}
