using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeSheetApplication.Models;
using TimeSheetApplication.ViewModels;

namespace TimeSheetApplication.Controllers
{
    public class HomeController:Controller
    {
        private readonly ITimesheetApplication timesheetApplication;

        public HomeController(ITimesheetApplication timesheetApplication)
        {
            this.timesheetApplication = timesheetApplication;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(EmployeeViewModel model)
        {
            if(ModelState.IsValid)
            {
                Employee emp = timesheetApplication.FetchEmployeeName(model.EmployeeShortName);
                if (emp != null)
                {
                    ViewBag.EmployeeName = "Employee Found";
                    model.EmpFirstName = emp.EmpFirstName;
                    model.EmpLastName = emp.EmpLastName;
                }
                else
                {
                    ViewBag.EmployeeName = "No Emp Found with this Short ID";
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult FillTimeCard()
        {
            return View();
        }
    }
}
