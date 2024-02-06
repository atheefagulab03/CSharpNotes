using System;

namespace CSharpIntermediate
{
    public class Intro
    {
        public string name;

        public void  hello(string name)
        {
            if(!string.IsNullOrWhiteSpace(name))
            {
                this.name= name;
            }
        }

        public string what()
        {
            return this.name;
        }

    }
    internal class Program
    {
        static void Main(string[] arg)
        {
           var g = new Intro();
            g.hello("Atheefa Gulab");
            Console.WriteLine("You can do it  {0}",g.what());

            // See properties now


        }
    }
}