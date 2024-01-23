using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals

{
    public enum Con
    {
        athee =7,
        gulab = 3
    }
    public class Program
    {
        static void Main(string[] args)
        {
            var first = "atheefa";
            var second = "gulab";
            
            //Concat
            var Name = first +" "+ second;
            Console.WriteLine(Name);

            //Format
            var format = string.Format("{0} {1}",first,second);
            Console.WriteLine(format);

            //join
            var num = new string[3] { "athe","zia","aaa"};

            string at = string.Join(",", num);
            Console.WriteLine(at);


            //enum
            var em = Con.athee;
            Console.WriteLine((int)em);
        }
    }
}
