using DataBizLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public class PermanentEmployee : BaseEmployee
    {
        public int MonthlySalary { get; set; }

        public PermanentEmployee()
        {

        }        

        public override decimal CalculateSalary()
        {
            return CompanyData.CompanyCurrentPerformancePercentage() * this.MonthlySalary / 100;
        }
    }
}
