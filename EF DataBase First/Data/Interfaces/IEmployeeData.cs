using Data.DataConcerns;

namespace Data.Interfaces
{

    public interface IEmployeeData
    {
        void AddingEmployee(Employee emp);
        bool IdValidation(string input);
        List<Employee> DisplayEmployees(string? inputId);
        void UpdatingAnEmployee(Employee emp);
        void DeletingAnEmployee(string? inputId);
    }
}
