using Casting;

internal class Program
{
    static void Main(string[] args)
    {
        //Derived class
        Student student = new Student();

        //Base class
        Teacher teacher = student;

        student.Id = 1;
        teacher.Id = 2;
        Console.WriteLine(student.Id);
        //both is pointing to the same obj


    }
}