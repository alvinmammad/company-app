using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyApp.Models;

namespace CompanyApp.Interfaces
{
   public interface IDepartment
    {
        List<Department> GetDepartments();
        Department GetDepartment(int id);
        Department Create(Department department);
        Department Edit(Department department);
        Department Delete(Department department);
    }
}
