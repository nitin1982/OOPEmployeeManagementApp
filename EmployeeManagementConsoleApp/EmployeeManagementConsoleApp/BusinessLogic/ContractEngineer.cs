using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public class ContractEngineer : ContractEmployee, IEngineer
    {
        public Project AssignedProject { get; set; }

        public void UpdateProjectProgress(int percentage)
        {
            this.AssignedProject.PercentageCompletion += percentage;
        }
    }
}
