namespace CSharpIntermediate;

public class user2 : user1
{
    public string LastName { get; set; }
    public string Email { get; set; }

    public void Info1()
    {
        Console.WriteLine("ik");
    }

    public user2(string name, string email) : base(name)
    {
        LastName = name;
        Email = email;
        Console.WriteLine("my last name is{0} and my email is{1} ", name, email);
    }

    public user2()
    {
        Console.WriteLine("user2");
    }

}
