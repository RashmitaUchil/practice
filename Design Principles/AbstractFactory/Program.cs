using AbstractFactory.Client;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee permanentEmpManager = new Employee(1, Employee.EmployeeType.Permanent, Employee.Position.Manager);
            Employee permanentEmpOther = new Employee(2, Employee.EmployeeType.Permanent, Employee.Position.Other);
            Employee contractEmpManager = new Employee(3, Employee.EmployeeType.Contract, Employee.Position.Manager);
            Employee contractEmpOther = new Employee(4, Employee.EmployeeType.Contract, Employee.Position.Other);

            List<Employee> employees = new List<Employee>();
            employees.Add(permanentEmpManager);
            employees.Add(permanentEmpOther);
            employees.Add(contractEmpOther);
            employees.Add(contractEmpManager);
            foreach (Employee employee in employees)
            {
                EmployeeSystemFactory factory = new EmployeeSystemFactory();
                IComputerFactory computer = factory.getComputer(employee);
                Console.WriteLine(employee.EmployeeDetails(employee));
                EmployeeSystemManager esm = new EmployeeSystemManager(computer);
                Console.WriteLine(esm.GetDetails());
                Console.WriteLine("---------------------------------------------------");
            }
        }
    }
}