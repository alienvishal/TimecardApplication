using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApplication.ViewModels
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage = "Please Enter the ShortID")]

        public string EmployeeShortName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
    }
}
