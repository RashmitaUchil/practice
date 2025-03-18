using System;

public class Program
{
    static void Main(string[] args) {
        int[] arr = new int[100];

        Random rand = new Random();

        for (int i = 0; i<arr.Length;i++)
        {
            arr[i] = rand.Next(1,100);
        }
        for (int i = 0; i < arr.Length; i++)
        {Console.WriteLine(arr[i]); }

            int eve= 0;
        int odd = 0;
        Parallel.For(0, arr.Length, i =>
        {
            if (arr[i] % 2 == 0)
            {
                eve++;
            }
            else
            {
                odd++;
            }
        });

        Console.WriteLine("eve:{0}, odd:{1}", eve, odd);
     }
    
}