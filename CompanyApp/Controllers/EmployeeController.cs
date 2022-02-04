using CompanyApp.Interfaces;
using CompanyApp.Models;
using CompanyApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = _employeeRepository.GetEmployees();
            return View(employees);
        }
        private readonly IEmployee _employeeRepository;
        private readonly IDepartment _departmentRepository;

        public EmployeeController(IEmployee employeeRepository , IDepartment departmentRepository)
        {
            _departmentRepository = departmentRepository;
             _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["DepartmentID"] = new SelectList(_departmentRepository.GetDepartments(), "ID", "DepName");

            //EmployeeViewModel vm = new EmployeeViewModel()
            //{
            //    Employees = new Employee(),
            //    Departments = _departmentRepository.GetDepartments().ToList()

            //};
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employee = _employeeRepository.Create(employee);
                    TempData["Success"] = "Employee created successfully";
                    return RedirectToAction(nameof(Index));

                }
                catch
                {

                }
            }
            //ViewData["DepartmentID"] = new SelectList(_departmentRepository.GetDepartments(), "ID", "DepName");
            //ViewBag.DepartmentID = new SelectList(_departmentRepository.GetDepartments(), "ID", "DepName");
            ViewData["DepartmentID"] = new SelectList(_departmentRepository.GetDepartments(), "ID", "DepName", employee.DepartmentID);


            return View(employee);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee= _employeeRepository.GetEmployee(id);
            ViewData["DepartmentID"] = new SelectList(_departmentRepository.GetDepartments(), "ID", "DepName", employee.DepartmentID);

            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit([Bind("ID,DepartmentID,FirstName,Surname,Age,Country,City,BirthDate,Salary,Phone,Email,Position")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employee = _employeeRepository.Edit(employee);
                    TempData["Success"] = "Employee updated successfully";
                    return RedirectToAction(nameof(Index));

                }
                catch
                {

                }

            }
            //ViewData["DepartmentID"] = new SelectList(_departmentRepository.GetDepartments(), "ID", "DepName");
            ViewData["DepartmentID"] = new SelectList(_departmentRepository.GetDepartments(), "ID", "DepName", employee.DepartmentID);

            return View(employee);

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee employee= _employeeRepository.GetEmployee(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {
            try
            {
                employee = _employeeRepository.Delete(employee);
                TempData["Success"] = "Employee deleted successfully";

            }
            catch
            {

            }

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Details(int id)
        {
            Employee employee= _employeeRepository.GetEmployee(id);
            return View(employee);
        }


    }
}
