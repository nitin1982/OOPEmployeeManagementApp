using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public class PermanentManager : PermanentEmployee, IManager
    {
        public Project[] Projects { get; set; }
        public IEngineer[] Engineers { get ; set ; }

        public void AssignProject(Project P, IEngineer eng)
        {
            eng.AssignedProject = P;            
        }

        public void SetTheProjectStatus()
        {
            foreach (Project P in Projects)
            {
                if (P.PercentageCompletion == 100){
                    P.Status = ProjectStatus.Closed;
                }else if (P.PercentageCompletion > 50)
                {
                    P.Status = ProjectStatus.InProgress;
                }
                else
                {
                    P.Status = ProjectStatus.Assigned;
                }
            }
        }

        public PermanentManager(int projectCount, int engineerCount)
        {
            this.Projects = new Project[projectCount];
            this.Engineers = new IEngineer[engineerCount];
        }
    }
}
