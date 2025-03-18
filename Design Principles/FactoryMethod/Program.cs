namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeFactory factory = new EmployeeFactory();
            IEmployeeManager? pe = factory.GetEmployee(EmployeeType.Permanent);
            Console.WriteLine("Hourly Pay for Permanent Employee is: " + pe?.hourlyPay());
            Console.WriteLine("Bonus for Permanent Employee is: " + pe?.bonus());

            IEmployeeManager? ce = factory.GetEmployee(EmployeeType.Contract);
            Console.WriteLine("Hourly Pay for Contract Employee is: " + ce?.hourlyPay());
            Console.WriteLine("Bonus for Contract Employee is: " + ce?.bonus());
        }
    }
}