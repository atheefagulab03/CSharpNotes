namespace AccesModifierLib;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Promote()
    {
        var calculate = cal();
        if (calculate == 0)
            Console.WriteLine("you are good");
        else Console.WriteLine("idk");


    }

    private int cal()
    {
        return 0;
    }

}
