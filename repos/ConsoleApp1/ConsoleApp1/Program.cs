using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message) { }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                throw new MyCustomException("This is a custom exception.");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Caught custom exception: {ex.Message}");
            }
        }
    }
}
