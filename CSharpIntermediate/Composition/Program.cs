namespace CSharpIntermediate;
internal class Program
{
    static void Main(string[] args)
    {
        var logging = new Logger();
        var db = new DbMigration(logging);
        var ins = new Install(logging);
        db.Migrate();
        ins.Instal();

    }
}