namespace Exceptions
{
    public class MyException(string message) : Exception(message)
    {
    }

    public class Calculate
    {
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new MyException("cannot divide by 0");
            }
            return (double)a / b;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Calculate.Divide(1, 0));
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("executed");
            }
        }
    }
}