using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(date);
            Console.WriteLine(today);
            Console.WriteLine(date.AddDays(-1));

            Console.WriteLine(date.Day);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);
            Console.WriteLine(date.Second);

            Console.WriteLine(date.ToString("dd-MM-yyyy"));
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToLocalTime());

        }
    }
}