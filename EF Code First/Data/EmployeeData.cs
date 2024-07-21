using Models;
using Utility;

namespace Data
{
    public class EmployeeData
    {
        //Adding an employee starts here
        public void AddingEmployee(Employee emp)
        {
            using (var context = new EmployeeDB())
            {
                context.Employees.Add(emp);
                context.SaveChanges();
            }
        }
        //Adding an employee ends here

        // ID validation starts here
        public bool IdValidation(string input)
        {
            using (var context = new EmployeeDB())
            {
                var employee = context.Employees.SingleOrDefault(emp => emp.ID == input);
                if (employee != null)
                    return true;
            }
            return false;
        }
        // ID validation ends here

        // Selecting all Employees/Single employee starts here
        public List<Employee> DisplayEmployees(string? inputId)
        {
            using (var context = new EmployeeDB())
            {
                if (inputId == null)
                {
                    var employees = context.Employees.ToList();
                    return employees;
                }
                else
                {
                    var employee = context.Employees.Where(emp => emp.ID == inputId).ToList();
                    return employee;
                }
            }
        }
        // Selecting all Employees/Single employee ends here

        // Editing an Employee starts here
        public void UpdatingAnEmployee(Employee emp)
        {
            using (var context = new EmployeeDB())
            {
                var employeeToUpdate = context.Employees.SingleOrDefault(e => e.ID == emp.ID);

                if (employeeToUpdate != null)
                {
                    context.Entry(employeeToUpdate).CurrentValues.SetValues(emp);
                    context.SaveChanges();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Prompts.EmployeeDeletedMessage);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Prompts.EmployeeIDErrorMessage);
                }
                context.SaveChanges();
            }
        }
        // Editing an Employee ends here

        // Deleting an Employee starts here
        public void DeletingAnEmployee(string? inputId)
        {
            using (var context = new EmployeeDB())
            {
                var employee = context.Employees.SingleOrDefault(emp => emp.ID == inputId);
                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Prompts.EmployeeDeletedMessage);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Prompts.EmployeeIDErrorMessage);
                }
            }
        }
        // Deleting an Employee ends here
    }
}
