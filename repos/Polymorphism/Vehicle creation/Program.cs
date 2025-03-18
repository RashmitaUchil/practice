using System;

public abstract class Vehicle
{
    public abstract void drive();
}
public class Car:Vehicle
{
    public override void drive()
    {
        Console.WriteLine("drives car");
    }
}

public class Bike : Vehicle
{
    public override void drive()
    {
        Console.WriteLine("drives Bike");
    }
}

public class Truck : Vehicle
{
    public override void drive()
    {
        Console.WriteLine("drives Truck");
    }
}

public class Program
{
    public static Vehicle createVehicle(string name)
    {
        switch(name.ToLower())
        {
            case "car":
                return new Car();
                break;

            case "bike":
                return new Bike();
                break;

            case "truck":
                return new Truck();
                break;

            default:
                throw new Exception("invalid vehicle");
                break;
        }
    }

    public static void Main(string[] args) {
        Console.WriteLine("Enter any vehicle i.e- Car, Truck ,Bike:");
        string name = Console.ReadLine();

        try
        {
            Vehicle v = createVehicle(name);

            v.drive();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        
    }

}
