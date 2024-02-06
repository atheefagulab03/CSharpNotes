namespace CSharpIntermediate;
internal class Program
{
    static void Main(string[] args)
    {
        var obj = new user2("atheefa ", "athee@gmail.com");
        var oo = new user2();
        //base class is initialized first and then the derived class

        obj.Info1();
        obj.Info();
    }
}