
namespace CSharpIntermediate
{
    public class Intro
    {
        public string name { get; set; }

        public string Name
        {
            set { name = value; }
            get { return name; }

        }

        /*public DateTime Birthday { get; set; }*/

        //when the birthday should not change 

        public DateTime Birthday { get; private set; }

        public Intro(DateTime birthday)
        {
            Birthday = birthday;
        }

        public int Age
        {
            get
            {
                var agee = DateTime.Today - Birthday;
                var total = agee.Days / 365;
                return total;
            }
        }

    }

    
    internal class Program
    {
        static void Main(string[] arg)
        {
            var g = new Intro(new DateTime(2002, 4, 3));
            g.Name = "ATHEFE";
            Console.WriteLine("HI {0}", g.Name);



            Console.WriteLine("enter your birthdate" + g.Birthday);
            Console.WriteLine(g.Age);



        }
    }
}