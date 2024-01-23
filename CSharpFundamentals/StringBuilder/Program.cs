using System;
using System.Text;

namespace CSharpFundamentals 
{
    public class Program
    {
        static void Main(string[] args)
        {
            var name = new StringBuilder("HELLO WORLD ATHEEFA");
            //Append
            name
                .Append('-', 10)
                .AppendLine()
                .Append("header");
            

            //replace
            name.Replace('-', '@');
            

            //remove
            name.Remove(0, 7);
            Console.WriteLine(name);

            //insert
            name.Insert(0, new string('-', 2));
            Console.WriteLine(name);

           

        }
    }
}