using CompanyApp.DAL;
using CompanyApp.Models;
using CompanyApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            EmployeeViewModel vm = new EmployeeViewModel()
            {
                EmployeeCount = _context.Employees.Count(),
                DepartmentCount = _context.Departments.Count()
            };
            return View(vm);
        }


    }
}
