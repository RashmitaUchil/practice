namespace AbstractFactory
{
    public class Employee
    {
        public enum EmployeeType
        {
            Permanent,
            Contract
        }

        public enum Position
        {
            Manager,
            Other
        }

        public int id;
        public EmployeeType type;
        public Position position;

        public Employee(int id, EmployeeType type, Position position)
        {
            this.id = id;
            this.position = position;
            this.type = type;
        }

        public string EmployeeDetails(Employee e)
        {
            string result = "Position:" + e.position.ToString() + ", Employee Type:" + e.type.ToString();
            return result;
        }
    }
}