using System;

public abstract class Animal
{
    public abstract void makeSound();
}

public class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("woof woof");
    }
}

public class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("meow meow");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Animal c = new Cat();
        c.makeSound();
        Animal d = new Dog();
        d.makeSound();
    }
}