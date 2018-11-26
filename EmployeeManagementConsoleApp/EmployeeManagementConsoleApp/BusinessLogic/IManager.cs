using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public interface IManager
    {
        Project[] Projects { get; set; }
        IEngineer[] Engineers { get; set; }

        void AssignProject(Project P, IEngineer eng);

        void SetTheProjectStatus();

    }
}
