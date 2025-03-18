using System;

public class Employee
{
    public virtual void work()
    {
        Console.WriteLine("Employee working");
    }
}

public class Manager:Employee
{
    public override void work()
    {
        Console.WriteLine("manager working");
    }

    public void managerWork()
    {
        Console.WriteLine("Manager's work");
    }
}
public class Developer:Employee
{
    public override void work()
    {
        Console.WriteLine("developer working");
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
        Employee manager = new Manager();
        manager.work();
        
        Employee developer = new Developer();
        developer.work();

        Console.WriteLine("Downcasting");
        Manager m= manager as Manager;
        Developer d= developer as Developer;

        m.managerWork();
        d.developerWork();
    }
}