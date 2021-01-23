using System.Collections.Generic;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static  List<Employee> Employees { get; } = new()
        {
            new Employee
            {
                Id = 1,
                LastName = "Петров",
                FirstName = "Иван",
                Patronymic = "Александрович",
                Job = "Директор",
                Age = 40,
                Salary = 140000,
                WorkExperience = 10
            },
            new Employee
            {
                Id = 2,
                LastName = "Иванов",
                FirstName = "Александр",
                Patronymic = "Петрович",
                Job = "Старший программист",
                Age = 35,
                Salary = 80000,
                WorkExperience = 5
            },
            new Employee
            {
                Id = 3,
                LastName = "Александров",
                FirstName = "Пётр",
                Patronymic = "Иванович",
                Job = "Веб-дизайнер",
                Age = 45,
                Salary = 70000,
                WorkExperience = 7
            }
        };
    }
}
