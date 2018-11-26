using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp.BusinessLogic
{
    public enum ProjectStatus
    {
        Assigned,
        InProgress,
        Closed
    }

    public class Project
    {
        public string Title { get; private set; }

        public Project(string projectTitle)
        {
            this.Title = projectTitle;
        }

        public int PercentageCompletion { get; set; }

        public ProjectStatus Status { get; set; }
    }
}
