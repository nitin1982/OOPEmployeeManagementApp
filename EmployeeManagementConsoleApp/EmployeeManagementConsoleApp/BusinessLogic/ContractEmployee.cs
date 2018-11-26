using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public class ContractEmployee : BaseEmployee
    {
        public decimal HourlyRate { get; set; }
        public int TotalHours { get; set; }
        public override decimal CalculateSalary()
        {
            return HourlyRate * TotalHours;
        }
    }
}
