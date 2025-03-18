using System;

public class Shape
{
    public virtual void draw()
    {
        Console.WriteLine("drawing a shape");
    }
}

public class Circle : Shape
{
    public override void draw()
    {
        Console.WriteLine("darwing a circle");
    }
}

public class Rectangle : Shape
{
    public override void draw()
    {
        Console.WriteLine("darwing a rectangle");
    }
}

public class program
{
    static void Main(string[] args)
    {
        Shape r= new Rectangle();
        r.draw(); ;
        Shape circle = new Circle();
        circle.draw();
    }
}