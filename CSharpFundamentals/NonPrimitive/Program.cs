using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Name
    {
        public string FName;
        public string LName;

        public void Intro()
        {
            Console.WriteLine("hi guys,"+FName+" "+LName);
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var name = new Name();
            name.FName = "atheefaa";
            name.LName = "gulab";
            name.Intro();
        }
    }
}