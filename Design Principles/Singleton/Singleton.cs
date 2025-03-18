namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
            counter++;
            Console.WriteLine("count:" + counter.ToString());
        }

        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void Print(string message)
        {
            Console.WriteLine("hello " + message);
        }
    }
}