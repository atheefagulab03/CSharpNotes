namespace CSharpIntermediate;
internal class Program
{
    static void Main(string[] args)
    {
        var cokkie = new HttpCookies();
        cokkie.set("name", "athee");
        Console.WriteLine(cokkie.get("name"));

       /* cokkie["name"] = ["atheefa"];
        Console.WriteLine(cokkie["name"]);*/

        // when i use indexer
    }
}