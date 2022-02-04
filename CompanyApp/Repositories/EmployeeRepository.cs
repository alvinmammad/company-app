using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyApp.DAL;
using CompanyApp.Interfaces;
using CompanyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyApp.Repositories
{
    public class EmployeeRepository:IEmployee
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Employee Create(Employee employee)
           
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee Delete(Employee employee)
        {
            _context.Employees.Attach(employee);
            _context.Entry(employee).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            _context.SaveChanges();
            return employee;
        }

        public Employee Edit(Employee employee)
        {
            _context.Employees.Attach(employee);
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
            return employee;
        }

        

        public Employee GetEmployee(int id)
        {
            
            Employee employee = _context.Employees.Include(e => e.Department).Where(e => e.ID == id).FirstOrDefault();
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = _context.Employees.Include(e => e.Department).ToList();
            return employees;
        }
    }
}
