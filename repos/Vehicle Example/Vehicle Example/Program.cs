using System;
using System.Runtime.CompilerServices;

public enum Type
{
    Car=1,
    Truck=2,
    Bike=3

}
public class Vehicle
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? Description { get; set; }
    public Vehicle type;
    public Vehicle(int id, string? name, string? description)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;

    }
    public void getDetails()
    {
        Console.WriteLine("Id:{0}, Name:{1}, Description:{2}", Id, Name, Description);
        Console.WriteLine("Type of the vehicle is:"+this.GetType());
    }
}

public class Car : Vehicle
{
    public Car(int  id, string? name, string? description):base(id, name, description) { }
    

}
public class Truck : Vehicle
{ 
    public Truck(int id, string? name, string? description) : base(id, name, description) { }
    
}
public class Bike : Vehicle
{
    public Bike(int id, string? name, string? description) : base(id, name, description) { }
   

}
public class Program
{
    public static Vehicle createvehicle(Type type,int id, string name, string description)
    {
        switch(type)
        {
            case Type.Car:
                return new Car(id,name, description);
                break;
            
            case Type.Truck:
                return new Truck(id, name, description);
                break;

            case Type.Bike:
                return new Bike(id, name, description);
                break;

            default:
                throw new Exception("Not known");
                break;

        }
    }

    public static void Main(string[] args)
    {
        List<Vehicle> list = new List<Vehicle>();
        string ch = "y";
        do
        {
            Console.WriteLine("Add a new vehicle: 1-car, 2-truck, 3-bike");
            int num = Convert.ToInt32(Console.ReadLine());

            Type type = (Type)num;

            Console.WriteLine("************Enter details*************");
            Console.Write("name:");
            var name = Console.ReadLine();
            Console.Write("description:");
            var desc = Console.ReadLine();
            Vehicle v = createvehicle(type, list.Count()+1, name, desc);
            v.getDetails();
            Console.WriteLine("___________________________________________");
            list.Add(v);
            Console.WriteLine("Do you want to add another vehicle?: y/n");
            ch = Console.ReadLine();
            Console.WriteLine("___________________________________________");

        }
        while (ch == "y");

        
        





    }
}