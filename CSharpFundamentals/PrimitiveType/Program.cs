using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion
            byte b = 1;
            int c = b;
            Console.WriteLine(c);

            //Excplicit Conversion 
            int i = 1;
            byte sb = (byte)i;
            Console.WriteLine(sb);

            //NON compatable
            var a = "123";
            int num = Convert.ToInt32(a);
            Console.WriteLine(num);

            //Postfix
            int ab = 1;
            int bd = ab++;

            Console.WriteLine(bd);
            Console.WriteLine(ab);

            //Prefix

            int x = 2;
            int y = ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //Arithmetic
            var first = 10;
            var second = 2;
            Console.WriteLine(first % second);
            Console.WriteLine(first / second);
        }
    }
}