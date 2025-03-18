using System;

public class Calculator
{

    public static int add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    public static int add(int a, int b, int c)
    {
        int sum = a + b+c;
        return sum;
    }
}

public class Program
{
    static void Main(string[] args)
    { 
    Console.WriteLine("sum:"+Calculator.add(1,2,3));
    }
}
