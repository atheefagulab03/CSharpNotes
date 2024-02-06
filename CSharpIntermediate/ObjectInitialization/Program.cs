using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Emp
        {
        public string Name;
        public string Description;
        }

     class Program
    {
        static void Main(string[] args)
        {
            var emp = new Emp();
            emp.Name = "atheefa";
            emp.Description = "Description";
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Description);



        }
    }
}