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
            new Employee { Id=1, LastName = "Петров", FirstName = "Иван", Patronymic = "Александрович",  Age = 40},
            new Employee { Id = 2, LastName = "Иванов", FirstName = "Александр", Patronymic = "Петрович", Age = 35 },
            new Employee { Id = 3, LastName = "Александров", FirstName = "Пётр", Patronymic = "Иванович", Age = 45 }
        };

        public IActionResult Index() => View();


        public IActionResult SecondAction() => View("SecondView");

        public IActionResult Employees() => View(employees);

    }
}
