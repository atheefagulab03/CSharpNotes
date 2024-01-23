using System;

namespace ControlFlow // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///if/else
            var atheefa = 18;
            if(atheefa == 18 && atheefa !=20)
            {
                Console.WriteLine("she is old");
            }
            else
            {
                Console.WriteLine("she is not old");
            }

            //ternary
            bool rate = false;
            float Sales = (rate) ? 12.2f : 11.2f;
            Console.WriteLine(Sales);

            //Switch with enum
            var sea = Season.Spring;

            switch(sea)
            {
                case Season.Autumn:
                    Console.WriteLine("Its Autumn");
                    break;

                case Season.summer: Console.WriteLine("its summer");
                    break;

                default: Console.WriteLine("i dont know");
                    break;
            }


            
        }
    }
}