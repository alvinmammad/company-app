using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyApp.DAL;
using CompanyApp.Interfaces;
using CompanyApp.Models;

namespace CompanyApp.Repositories
{
    public class DepartmentRepository : IDepartment
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;

        }

        public List<Department> GetDepartments()
        {
            List<Department> departments = _context.Departments.ToList();
            return departments;
        }
        public Department GetDepartment(int id)
        {
            Department department = _context.Departments.Where(d => d.ID == id).FirstOrDefault();
            return department;
        }



        public Department Create(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }

        public Department Edit(Department department)
        {
            _context.Departments.Attach(department);
            _context.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return department;
        }

        public Department Delete(Department department)
        {
            _context.Departments.Attach(department);
            _context.Entry(department).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return department;
        }

    }
}
