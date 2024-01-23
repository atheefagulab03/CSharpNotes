using System;

namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////int
            //var number = new int[5] { 1, 2, 3, 4 ,7};

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine(number[i]);
            //}

            ////bool
            //var b = new bool[2] {false, true};

            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine(b[i]);
            //}

            ////string
            //var st = new string[2] { "atheefa", "zia" };

            //foreach(string i in st)
            //{
            //    Console.WriteLine(i);
            //}

            //single 
            var single = new int[3] { 1, 2, 3 };

            Console.WriteLine("the length"+single.Length);

            //index

            //for (int i = 0; i < single.Length; i++)
            //{
            //    if (single[i] == 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //clear

            var list = new List<int>() { 1, 2, 3 };

            list.Add(1);
            foreach (int i in list)
            {
                Console.WriteLine(list[i]);
            }




        }
    }
}