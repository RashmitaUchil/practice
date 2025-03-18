namespace Practice
{
    public class Program
    {
        private delegate void NotifyDelegate(string msg);

        public static void SendEmailNotification(string msg)
        {
            Console.WriteLine("Email: " + msg);
        }

        public static void SendSMSNotification(string msg)
        {
            Console.WriteLine("SMS: " + msg);
        }

        private static void Main(string[] args)
        {
            NotifyDelegate notify = SendEmailNotification;
            notify += SendSMSNotification;

            notify("Event Scheduled on 20th Feb at 5 PM");
        }
    }
}