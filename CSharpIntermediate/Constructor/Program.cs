using Constructor;
using System;

namespace CSharpIntermediate
{
    public class Employee
    {
       
        public string Name;
        public int Id;
        public List<Order> Orders;

        public Employee()
        {
            //Orders = new List<Order>();
        }

        public Employee( string name, int id ) : this() 
        {
       
      this.Name = name;
            this.Id = id;
        }

    }
     class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("Atheefa", 21);
            Console.WriteLine("Hi I am {0} and I am {1}",emp.Name,emp.Id);
           
        }
    }
}