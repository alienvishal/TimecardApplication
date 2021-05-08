using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApplication.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeShortName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpLastName { get; set; }
        public int RoleID { get; set; }
        [ForeignKey("RoleID")]
        public virtual Roles Roles { get; set; }
    }
}
