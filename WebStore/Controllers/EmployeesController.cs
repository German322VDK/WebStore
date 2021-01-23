using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    //[Route("staff")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeesData _IEmployeesData;

        public EmployeesController(IEmployeesData IEmployeesData) => _IEmployeesData = IEmployeesData;

        //[Route("all")]
        public IActionResult Index() => View(_IEmployeesData.Get());

        //[Route("info(id-{id})")]
        public IActionResult Details(int id) // http://localhost:5000/employees/details/2
        {
            var employee = _IEmployeesData.Get(id);
            if (employee is not null)
                return View(employee);
            return NotFound();
        }

        public IActionResult Create() => View("Edit", new EmployeeViewModel());

        #region Edit

        public IActionResult Edit(int id)
        {
            if (id <= 0) return BadRequest();

            var employee = _IEmployeesData.Get((int)id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Patronymic = employee.Patronymic,
                Job = employee.Job,
                Age = employee.Age,
                Salary = employee.Salary,
                WorkExperience = employee.WorkExperience
            });
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            if (model is null)
                throw new ArgumentNullException(nameof(model));

           var employee = new Employee
            {
               Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Patronymic = model.Patronymic,
                Job = model.Job,
                Age = model.Age,
                Salary = model.Salary,
               WorkExperience = model.WorkExperience
           };

            if (employee.Id == 0)
                _IEmployeesData.Add(employee);
            else
                _IEmployeesData.Update(employee);

            return RedirectToAction("Index");
        }

        #endregion

        #region Delete

        public IActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest();

            var employee = _IEmployeesData.Get((int)id);

            if (employee is null)
                return NotFound();

            return View(new EmployeeViewModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Patronymic = employee.Patronymic,
                Job = employee.Job,
                Age = employee.Age,
                Salary = employee.Salary,
                WorkExperience = employee.WorkExperience
            });
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            _IEmployeesData.Delete(id);

            return RedirectToAction("Index");
        }

        #endregion

    }
}
