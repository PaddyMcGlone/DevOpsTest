using System;


namespace DevOpsTestApp
{
    class Program
    {
        static void Main()
        {
            var message = Greeting();
            Console.WriteLine(message);
            Console.ReadLine();
        }

        static string Greeting()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour < 12)
                return "Good Morning";

            if (currentHour > 12 && currentHour < 20)
                return "Good Afternoon";

            return "Good Evening";
        }
    }
}
