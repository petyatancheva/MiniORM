namespace MiniORM.App
{
    using Data;
    using Data.Entities;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var connectionString = "Server=.;Database=MiniORM;Integrated Security=true";

            var context = new SoftUniDbContext(connectionString);

            context.Employees.Add(new Employee
            {
                FirstName = "Petya",
                LastName = "Tancheva",
                DepartmentId = context.Departments.First().Id,
                IsEmployed = true,
            });

            Employee employee = context.Employees.Last();

            System.Console.WriteLine(employee.FirstName + " " + employee.LastName);

            context.Employees.Remove(employee);

            context.SaveChanges();
        }
    }
}
