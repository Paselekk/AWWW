using Microsoft.AspNetCore.Mvc;
using AWWW_Lab1.Models;

namespace AWWW_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int id=1)
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Artur",
                    LastName = "M",
                    Indeks = 135000,
                    BirthdayDate = new DateTime(2001,3,28),
                    Facility = "Informatyka"
                },
                new Student
                {
                    Id = 1,
                    Name = "Jakub",
                    LastName = "P",
                    Indeks = 135100,
                    BirthdayDate = new DateTime(2001,1,1),
                    Facility = "Informatyka"
                },
                new Student
                {
                    Id = 1,
                    Name = "Jakub",
                    LastName = "K",
                    Indeks = 135200,
                    BirthdayDate = new DateTime(2001,2,2),
                    Facility = "Informatyka"
                }
            };
            return View(students[id-1]);
        }
    }
}
