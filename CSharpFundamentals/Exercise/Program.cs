using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1 
            Console.WriteLine("Enter a number :");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number <= 10)
            {
                Console.WriteLine(" The number is{0}", number);
            }
            else
            {
                Console.WriteLine("The number is more than 10");
            }

            //ex2
            Console.WriteLine("Enter the first ");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second");
            var second = Convert.ToInt32(Console.ReadLine());

            if (first < second && second != 0)
            {
                Console.WriteLine("first  is small");
            }
            else
            {
                Console.WriteLine("second is small");
            }
            //ex3
            Console.WriteLine("enter the width");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the length");
            var length = Convert.ToInt32(Console.ReadLine());
            if (width > length)
            {
                Console.WriteLine("this is landscape");

            }
            else
            {
                Console.WriteLine("This is potrait");
            }

            //ex4

            int temp = 0;

            for (int i = 2; i < 100; i++)
            {

                temp += i;


            }
            Console.WriteLine(temp);

            //ex5
            Console.WriteLine("enter the input");

            var tempss = 0;


            while (true)
            {
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    Console.WriteLine(" ok");
                    break;
                }
                int num = int.Parse(input);
                tempss = tempss + num;

            }
            Console.WriteLine("the output is {0}", temp);

            //ex6
            Console.WriteLine("enter a number");
            int numbers = Convert.ToInt32(Console.ReadLine());
            var temps = 1;

            if (numbers != 0)
            {
                for (int i = 2; i <= number; i++)
                {
                    temps = temps * i;
                }
                Console.WriteLine(temp);
            }

            //ex7
            var random = new Random();
            var stored = random.Next(1,10);
            Console.WriteLine(stored);


            
            
            
           
                
                
                for (int count=1; count <= 4;count ++) 
                {
                Console.WriteLine("enter a random num");

                if (int.TryParse(Console.ReadLine(), out int expected))
                {
                    if (stored == expected)
                    {
                        Console.WriteLine("WON");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("try again");
                        
                    }
                }
                else
                {
                    count--;
                    Console.WriteLine(count);
                }

                    
                    
                }
               

                
                
            



        }
    }
}