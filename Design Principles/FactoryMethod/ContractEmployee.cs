namespace FactoryMethod
{
    public class ContractEmployee : IEmployeeManager
    {
        public int bonus()
        {
            return 7;
        }

        public int hourlyPay()
        {
            return 11;
        }
    }
}