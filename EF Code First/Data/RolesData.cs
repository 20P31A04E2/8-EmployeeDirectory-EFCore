using Models;

namespace Data
{
    public class RolesData
    {
        // Adding a role starts here
        public void AddingRole(Role r)
        {
            using (var context = new EmployeeDB())
            {
                context.Roles.Add(r);
                context.SaveChanges();
            }
        }
        // Adding a role ends here

        // Displaying all Employees/Single employee starts here
        public List<Role> DisplayEmployees()
        {
            using (var context = new EmployeeDB())
            {
                    var roles = context.Roles.ToList();
                    return roles;
            }
        }
        // Displaying all Employees/Single employee ends here
    }
}
