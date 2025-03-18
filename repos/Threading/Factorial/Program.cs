using System;

public class Program
{
    public static int fact(int num)
    {
        if (num <= 1)
        {
            return 1;
        }
        else
        {
            return num * fact(num - 1);
        }
    }

    static async Task Main(string[] args)
    {
        List<Task> tasks = new List<Task>();

        for (int i = 0; i < 10; i++) {
            int num = i;
            tasks.Add(Task.Run(() =>
            Console.WriteLine("Factorial of {0} is {1}", num, fact(num))));
        }

        await Task.WhenAll(tasks);
    } 
}