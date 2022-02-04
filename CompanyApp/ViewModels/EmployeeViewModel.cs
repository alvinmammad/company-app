using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyApp.Models;
namespace CompanyApp.ViewModels
{
    public class EmployeeViewModel
    {
        public Employee Employees { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
