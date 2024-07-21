using Data.DataConcerns;
using Data.Interfaces;

namespace Data
{
    public class RolesData : IRoleData
    {
        // Adding a role starts here
        public void AddingRole(Role r)
        {
            using (var context = new EmployeeDBContext())
            {
                context.Roles.Add(r);
                context.SaveChanges();
            }
        }
        // Adding a role ends here

        // Displaying all Employees/Single employee starts here
        public List<Role> DisplayRoles()
        {
            using (var context = new EmployeeDBContext())
            {
                    var roles = context.Roles.ToList();
                    return roles;
            }
        }
        // Displaying all Employees/Single employee ends here
    }
}
