

namespace CSharpIntermediate;
internal class Program
{
    static void Main(string[] args)
    {
        var db = new DbMigration(new ConsoleLogger());
        db.Migrate();

    }
}