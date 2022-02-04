using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyApp.DAL;
using CompanyApp.Models;
using CompanyApp.Interfaces;

namespace CompanyApp.Controllers
{
    public class DepartmentController : Controller
    {
       
        public IActionResult Index()
        {
            
            List<Department> departments = _departmentRepository.GetDepartments();
            return View(departments);
        }
        
        private readonly IDepartment _departmentRepository;

        public DepartmentController( IDepartment departmentRepository)
        {
           
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public IActionResult Create()
        {
            Department department = new Department();
            return View(department);
        }
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    department = _departmentRepository.Create(department);
                    TempData["Success"] = "Department created successfully";
                    return RedirectToAction(nameof(Index));

                }
                catch
                {
                
                }
            }

            return View(department);
            

        }

        public IActionResult Details(int id)
        {
            Department department = _departmentRepository.GetDepartment(id);
            return View(department);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Department department = _departmentRepository.GetDepartment(id);
            return View(department);
        }
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    department = _departmentRepository.Edit(department);
                    TempData["Success"] = "Department updated successfully";
                    return RedirectToAction(nameof(Index));
                }
                catch
                {

                }
            }

            return View(department);

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Department department = _departmentRepository.GetDepartment(id);
            return View(department);
        }
        [HttpPost]
        public IActionResult Delete(Department department)
        {
            try
            {
                department = _departmentRepository.Delete(department);
                TempData["Success"] = "Department deleted successfully";

            }
            catch
            {

            }
            
            return RedirectToAction(nameof(Index));
        }

        
    }
}
