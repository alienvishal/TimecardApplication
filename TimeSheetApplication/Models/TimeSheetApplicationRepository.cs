using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheetApplication.Models
{
    public class TimeSheetApplicationRepository : ITimesheetApplication
    {
        private readonly TimeSheetDBContext timeSheetDBContext;

        public TimeSheetApplicationRepository(TimeSheetDBContext timeSheetDBContext)
        {
            this.timeSheetDBContext = timeSheetDBContext;
        }
        public Employee FetchEmployeeName(string ShortID)
        {
            Employee emp = timeSheetDBContext.Employees.Where(x => x.EmployeeShortName == ShortID.ToLower()).FirstOrDefault();
            return emp;
        }
    }
}
