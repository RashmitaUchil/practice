using System;

public interface Vehicle
{
    public void start();
}

public class Bike:Vehicle
{
    public void start()
    {
        Console.WriteLine("bike started");
    }
}

public class Car : Vehicle
{
    public void start()
    {
        Console.WriteLine("car started");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Vehicle b=new Bike();
        b.start();
        Vehicle c=new Car();
        c.start();
    }
}