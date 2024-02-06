namespace MethodOverriding
{
    public class circle : shape
    {
        public override void Draw()
        {

            base.Draw();
            Console.WriteLine("Its a circle");
        }
    }
}