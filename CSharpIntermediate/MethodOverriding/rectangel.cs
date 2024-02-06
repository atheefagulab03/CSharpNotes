namespace MethodOverriding
{
    public class rectangel : shape
    {
        public override void Draw()
        {

            base.Draw();
            Console.WriteLine("Its a rectangel");
        }

    }
}