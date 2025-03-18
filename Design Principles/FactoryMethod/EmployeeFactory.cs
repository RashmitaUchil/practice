namespace FactoryMethod
{
    public class EmployeeFactory
    {
        public IEmployeeManager? GetEmployee(EmployeeType type)
        {
            IEmployeeManager? emp = null;
            if (type == EmployeeType.Permanent)
            {
                return new PermanentEmployee();
            }
            else if (type == EmployeeType.Contract)

            { return new ContractEmployee(); }

            return emp;
        }
    }
}