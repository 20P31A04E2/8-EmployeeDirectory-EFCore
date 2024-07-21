using Data.DataConcerns;

namespace Data.Interfaces
{
    public interface IRoleData
    {
        void AddingRole(Role r);
        List<Role> DisplayRoles();
    }
}
