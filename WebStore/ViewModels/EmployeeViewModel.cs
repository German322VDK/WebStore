using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; init; }

        public string FirstName { get; init; }

        public string LastName { get; init; }

        public string Patronymic { get; init; }

        public string Job { get; init; }

        public int Age { get; init; }

        public int Salary { get; init; }

        public int WorkExperience { get; init; }
    }
}
