using EmployeeManagementConsoleApp.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name: Long Lewis
            // Permanent Employee, Manager
            // Two Projects - P1, P2
            // Three Reportee Employees - E1(Permanent Engineer), E2(Permanent Engineer), E3(Contract Engineer)
            // Call Assign Project three times
            // E1 - P1
            // E2 - P2
            // E3 - P3

            // E1 Calls UpdateProjectProgress, sets assignedProjectStatus progress as 95%
            // E2 Calls UpdateProjectProgress, sets assignedProjectStatus progress as 45%
            // E3 Calls UpdateProjectProgress, sets assignedProjectStatus progress as 55%

            // Manager Long Lewis calls CurrentProjectStatus, display current status.

            PermanentManager permMgr = new PermanentManager(2, 3);
            permMgr.FName = "Lewis";
            permMgr.LName = "Long";
            permMgr.MonthlySalary = 8000;
            permMgr.Title = "Senior Manager Technology";
            permMgr.BusinessUnit = "Software Development";
            

            Project p1 = new Project("Finance Monthly Report web App.");
            Project p2 = new Project("HR resource allocation internal app.");

            PermanentEngineer permEngg = new PermanentEngineer();
            permEngg.FName = "Sam";
            permEngg.LName = "Blair";
            permEngg.MonthlySalary = 5000;
            permEngg.Title = "Software Developer";
            permEngg.BusinessUnit = "Software Development";
            //DisplayEmployeeDetail(permEngg);

            ContractEngineer contractEngg1 = new ContractEngineer();
            contractEngg1.FName = "Mike";
            contractEngg1.LName = "Lee";
            contractEngg1.HourlyRate = 70;
            contractEngg1.TotalHours = 160;
            contractEngg1.Title = "Software Web Developer";
            contractEngg1.BusinessUnit = "Software Development";
            //DisplayEmployeeDetail(contractEngg1);

            ContractEngineer contractEngg2 = new ContractEngineer();
            contractEngg2.FName = "John";
            contractEngg2.LName = "Peterson";
            contractEngg2.HourlyRate = 60;
            contractEngg2.TotalHours = 160;
            contractEngg2.Title = "Software Developer";
            contractEngg2.BusinessUnit = "Software Development";
            //DisplayEmployeeDetail(contractEngg2);

            permMgr.Projects[0] = p1;
            permMgr.Projects[1] = p2;

            permMgr.Engineers[0] = permEngg;
            permMgr.Engineers[1] = contractEngg1;
            permMgr.Engineers[2] = contractEngg2;

            permMgr.AssignProject(p1, permEngg);
            permMgr.AssignProject(p1, contractEngg1);

            permMgr.AssignProject(p2, contractEngg2);

            

            DisplayEmployeeDetail(permMgr);
            foreach (BaseEmployee item in permMgr.Engineers)
            {
                DisplayEmployeeDetail(item);
            }

            Console.WriteLine("Project Status");
            DisplayProjectsSummary(permMgr.Projects);

            permEngg.UpdateProjectProgress(50);
            contractEngg1.UpdateProjectProgress(50);
            contractEngg2.UpdateProjectProgress(40);

            Console.WriteLine("Project Status later");
            permMgr.SetTheProjectStatus();
            DisplayProjectsSummary(permMgr.Projects);

            Console.ReadLine();

        }

        static void DisplayEmployeeDetail(BaseEmployee emp)
        {
            Console.WriteLine($"Employee Detail");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Emp Name: { emp.FName} {emp.LName}");
            Console.WriteLine($"Title: { emp.Title}");
            Console.WriteLine($"BusinessUnit: { emp.BusinessUnit}");
            Console.WriteLine($"Total Monthly Salary: {emp.CalculateSalary()}");


            if (emp is PermanentEmployee)
            {
                Console.WriteLine($"Employment Type: Permanent");
            }
            if (emp is ContractEmployee)
            {
                Console.WriteLine($"Employment Type: Contract");
            }
            if (emp is IManager)
            {
                Console.WriteLine($"Role: Manager");
                IManager mgr = emp as IManager;
                string projectsDetail = "";

                foreach (Project project in mgr.Projects)
                {
                    projectsDetail = projectsDetail + project.Title + ", ";
                }
                Console.WriteLine($"Projects:{ projectsDetail.Substring(0, projectsDetail.Length - 2) }");
            }

            if (emp is IEngineer)
            {
                Console.WriteLine($"Role: Engineer");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"-----------------");
            Console.WriteLine("  ");
        }

        static void DisplayProjectsSummary(Project[] projects)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Project project in projects)
            {
                Console.WriteLine($"Project: {project.Title}, {project.Status}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
