using System;

namespace CSharpFundamentals

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }



            //foreach
            var athee = new int[6] { 1, 2, 3, 3, 2, 2 };

            for (int i = 0; i < athee.Length; i++)
            {
                Console.WriteLine(athee[i]);
            }

            foreach (int i in athee)
            {
                Console.WriteLine(i);
            }


            //for and foreach
            var atr = "atheefa gulab";
            for (int i = 0; i < atr.Length; i++)
            {
                Console.WriteLine(atr[i]);
            }

            foreach (var i in atr)
            {
                Console.WriteLine(i);
            }

            //while
            var athe = 10;

            while (athe <= 10)
            {
                Console.WriteLine(athe);
                athe++;
            }

           // DoWhile
            do
            {
                Console.WriteLine(athe);
                athe++;
            } while (athe <= 12);


            //random class
            var ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((char)ran.Next(99,122));
                Console.WriteLine(ran.Next());
            }

            
        }
    }
}