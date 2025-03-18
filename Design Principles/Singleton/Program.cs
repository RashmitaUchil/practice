namespace SingletonDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Parallel.Invoke(
            () => PrintStudent(),
            () => PrintEmployee());
        }

        private static void PrintEmployee()
        {
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.Print("fromEmployee");
        }

        private static void PrintStudent()
        {
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.Print("fromStudent");
        }
    }
}