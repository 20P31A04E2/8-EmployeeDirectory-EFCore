using Utility;
using Data;
using Models;

namespace Services
{
    public class RolesManagementMenu
    {
        EmployeeManagementMenu AddRoles = new EmployeeManagementMenu();
        RolesData roleData = new RolesData();

        //Role Management starts here
        public void RoleManagement()
        {
            bool isRoleMenu = true;
            while (isRoleMenu)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(Prompts.RoleMenu);
                Console.Write(Prompts.SelectedOption);
                int roleMenuChoice;
                if (!int.TryParse(Console.ReadLine(), out roleMenuChoice) || roleMenuChoice < 1 || roleMenuChoice > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Prompts.InvalidMessage);
                    continue;
                }
                switch ((RoleManagementMenu)roleMenuChoice)
                {
                    case RoleManagementMenu.AddRole:
                        AddRole();
                        break;
                    case RoleManagementMenu.DisplayAll:
                        DisplayAll();
                        break;
                    case RoleManagementMenu.IsRoleMenu:
                        isRoleMenu = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Prompts.InvalidMessage);
                        break;
                }
            }
        }
        //Role Management ends here

        //Add role starts here
        private void AddRole()
        {
            Console.WriteLine("\nEnter the role details to add: ");
            string? roleName = AddRoles.InputValidation("string", "Enter Role Name: ");
            string? department = AddRoles.InputValidation("string", "Enter Department Name: ");
            string? roleDescription = AddRoles.InputValidation("stringornull", "Enter Role Description: ");
            string? location = AddRoles.InputValidation("string", "Enter Location: ");

            Role role = new Role { RoleName = roleName, Department= department, RoleDescription=roleDescription, Location=location};
            roleData.AddingRole(role);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Prompts.RoleAddedMessage);
        }
        //Add role ends here


        //Display all start here
        private void DisplayAll()
        {
                Console.ForegroundColor = ConsoleColor.White;
                List<Role> role = roleData.DisplayEmployees();
                if (role.Any())
                {
                    Console.WriteLine();
                    int count = 1;
                    foreach (var r in role)
                    {
                        Console.WriteLine($"{count}) RoleName: {r.RoleName}, Department: {r.Department}, Role Description: {r.RoleDescription}, Location: {r.Location}");
                        Console.WriteLine("====================================================================================================================================================");
                        count++;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Prompts.NoRolesMessage);
                }
        }
        //Display all ends here
    }
}