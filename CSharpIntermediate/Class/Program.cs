using System;

namespace CSharpIntermediate
{
    public  class Intro
    {
        public string? Name;

        public string? SurName;

        public void Greet(string opp)
        {
            Console.WriteLine("hi {0} I am {1}  {2}",opp,Name,SurName);
        }

    }
    internal class Program
    {
        static void Main(string[] arg)
        {
            var cla = new Intro();
            cla.Name = "Atheefa";
            cla.SurName = "Gulab";
            cla.Greet("Zia");
        }
    }
}