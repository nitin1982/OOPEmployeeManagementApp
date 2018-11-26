using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public interface IEngineer
    {
        Project AssignedProject { get; set; }
        void UpdateProjectProgress(int percentage);
    }
}
