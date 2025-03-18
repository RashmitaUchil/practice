using System;
using System.Threading;
public class ThreadExample
{
    public static void ThreadsEx()
    {
        Thread t1 = new Thread(() => Console.WriteLine("Thread 1 is running"));
        t1.Start();

        Thread t2 = new Thread(() => Console.WriteLine("Thread 2 is running"));
        t2.Start();

        Thread t3 = new Thread(() => Console.WriteLine("Thread 3 is running"));
        t3.Start();
    }
}
public class Program
{
    static void Main(string[] args)
    {
        ThreadExample.ThreadsEx();
        
    }
}