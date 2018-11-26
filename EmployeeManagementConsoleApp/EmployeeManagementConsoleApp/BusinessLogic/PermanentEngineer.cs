using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public class PermanentEngineer : PermanentEmployee, IEngineer
    {
        public Project AssignedProject { get; set; }

        public void UpdateProjectProgress(int percentage)
        {
            this.AssignedProject.PercentageCompletion += percentage;
        }
    }
}
