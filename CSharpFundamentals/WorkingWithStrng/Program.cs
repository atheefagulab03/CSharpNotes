using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullname = "Atheefa Gulab ";

            Console.WriteLine(" "+ fullname.ToUpper());
            Console.WriteLine(" " + fullname.ToLower());

            //split a string 
            var index = fullname.IndexOf(' ');
            var first = fullname.Substring(0, index);
            var last = fullname.Substring(index + 1);
            Console.WriteLine(first + "  " + last);
            //split 
            var names= fullname.Split(' ');
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            //replace
           var at = fullname.Replace("Atheefa", "athee");
             Console.WriteLine(at);

        }
    }
}