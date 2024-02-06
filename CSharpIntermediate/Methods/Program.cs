

namespace CSharpIntermediate;

public class point
{
    public int x;
    public int y;

    public point(int x, int y)
    {
        this.y = y;
        this.x = x;
    }

    public void Move(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(point NewLoc)
    {
        Move(NewLoc.x, NewLoc.y);
    }
}
class Program
{
    static void Main(string[] args)
    {
        var value = new point(1, 2);
        value.Move(new point(22, 2));
        Console.WriteLine("the points are :{0} {1} ", value.x, value.y);

        value.Move(4, 3);
        Console.WriteLine("the new point :{0} {1}", value.x, value.y);


    }

}