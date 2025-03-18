using Adapter.Adaptee;
using Adapter.Adapter;
using Adapter.Target;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        
        {
            IEmployee e = new EmployeeAdapter();
            
            string value = e.GetAllEmployees();
            Console.ReadLine();
        }
    }
}