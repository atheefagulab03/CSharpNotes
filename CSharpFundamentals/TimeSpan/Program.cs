using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Time = new TimeSpan(1,2,2,2);
            Console.WriteLine(Time);
            var time = TimeSpan.FromHours(1);
            Console.WriteLine(time);
        }
    }
}
