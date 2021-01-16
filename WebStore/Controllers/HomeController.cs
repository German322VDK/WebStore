using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public static readonly List<Employee> employees = new()
        {
            new Employee { Id=1, LastName = "Петров", FirstName = "Иван", Patronymic = "Александрович", 
                Job = "Директор",  Age = 40, Salary = 140000, WorkExperience=10},
            new Employee { Id = 2, LastName = "Иванов", FirstName = "Александр", Patronymic = "Петрович",
                Job = "Старший программист", Age = 35, Salary = 80000, WorkExperience=5 },
            new Employee { Id = 3, LastName = "Александров", FirstName = "Пётр", Patronymic = "Иванович",
                Job = "Веб-дизайнер", Age = 45, Salary = 70000, WorkExperience = 7}
        };

        public IActionResult Index() => View();

        public IActionResult SecondAction() => View("SecondView");

        public IActionResult Employees() => View(employees);

        public IActionResult Employee(int i)
        {
            var result = employees.Find(emp => emp.Id == i);
            return View(result);
        }


    }
}
