using System.Collections;

internal class Program
{
    static void Main(string[] args)
    {
        var arr = new ArrayList();
        arr.Add(1);
        arr.Add("jii");
        Console.WriteLine(arr[1].ToString());

        int nume = 1;
        Object obj = nume;
        Console.WriteLine(obj.ToString());
        int objs = (int)obj;
        Console.WriteLine(objs.ToString());
    }
}