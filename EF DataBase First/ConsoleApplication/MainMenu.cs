using Services;
using Services.Interfaces;
using Utility;
namespace ConsoleApplication
{


    public class MainMenu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nSelect an option:\n1. Employee Management\n2. Role Management\n3. Exit ");
                Console.Write("Selected option is: ");
                int menuChoice;
                if (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice < 1 || menuChoice > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option. Please try again.");
                    continue;
                }

                switch ((MenuOption)menuChoice)
                {
                    case MenuOption.EmployeeManagement:
                        IEmployeeService employeeMenu = new EmployeeManagementMenu();
                        employeeMenu.EmployeeManagement();
                        break;
                    case MenuOption.RoleManagement:
                        IRoleService roleMenu = new RolesManagementMenu();
                        roleMenu.RoleManagement();
                        break;
                    case MenuOption.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

