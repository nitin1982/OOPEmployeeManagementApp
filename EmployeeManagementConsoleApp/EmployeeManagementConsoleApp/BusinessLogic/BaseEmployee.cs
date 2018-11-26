using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public abstract class BaseEmployee
    {
        public int EmpID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Title { get; set; }
        public string BusinessUnit { get; set; }

        public abstract decimal CalculateSalary();
    }
}
