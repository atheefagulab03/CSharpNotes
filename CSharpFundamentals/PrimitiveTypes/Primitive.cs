using System;


namespace PrimitiveTypes
{
    internal class Primitive
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
        }
    }
}
