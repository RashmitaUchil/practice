using System;

public class Employee
{
    public int Id { get; set; } public string Name { get; set; }
    public virtual void getDetails()
    {
        Console.WriteLine("Id:{0}, Name:{1}",Id,Name);
    }
}

public class Manager : Employee
{
    public override void getDetails()
    {
        Console.WriteLine("Id:{0}, Name:{1}", Id, Name+"-Manager");
    }

    public void managerWork()
    {
        Console.WriteLine("Manager's work");
    }
}
public class Developer : Employee
{
    public override void getDetails()
    {
        Console.WriteLine("Id:{0}, Name:{1}", Id, Name + "-Developer");
    }

    public void developerWork()
    {
        Console.WriteLine("Developer's work");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Manager m1 = new Manager
        {
            Id = 1,
            Name = "manager 1"
        };
        Manager m2 = new Manager
        {
            Id = 3,
            Name = "manager 2"
        };
        Manager m3 = new Manager
        {
            Id = 5,
            Name = "manager 3"
        };
        Manager m4 = new Manager
        {
            Id = 6,
            Name = "manager 4"
        };


        Developer d1 = new Developer
        {
            Id = 2,
            Name="developer 1"

        };
        Developer d2 = new Developer
        {
            Id = 4,
            Name = "developer 2"

        };
        Developer d3 = new Developer
        {
            Id = 7,
            Name = "developer 3"

        };

        List<Employee> employees = new List<Employee> {m1,m2,m3,m4,d1,d2,d3};

        var sorted=employees.OrderBy(e => e.Id);
        foreach(Employee employee in sorted)
        {
            employee.getDetails();
        }
       
    }
}