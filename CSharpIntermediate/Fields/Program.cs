using System;

namespace CSharpIntermediate
{


    internal class Program
    {
        static void Main(string[] args)
        {
            var cus = new Customer(1);
            cus.Orders.Add(new Order());
            cus.Orders.Add(new Order());

            //the count is 2 
            /*cus.Promote();*/
            //After re initialization count is 0 so we need to use read only in field 
            Console.WriteLine(cus.Orders.Count);
        }
    }
}