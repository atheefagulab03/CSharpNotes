namespace CSharpIntermediate;

public class user1
{
    public string Name { get; set; }
    public string Password { get; set; }

    public void Info()
    {
        Console.WriteLine("idk");
    }

    public user1(string name)
    {
        Name = name;
        Console.WriteLine("first name is {0}", name);

    }

    public user1()
    {
        Console.WriteLine("user1 ");
    }

}
