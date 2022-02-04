using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyApp.Models;


namespace CompanyApp.Interfaces
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        Employee Create(Employee employee);
        Employee Edit( Employee employee);
        Employee Delete(Employee employee);
    }
}
