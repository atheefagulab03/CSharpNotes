namespace CSharpIntermediate;

public class DbMigration
{
    private readonly Logger logger;

    public DbMigration(Logger logger)
    {
        this.logger = logger;
    }

    public void Migrate()
    {
        logger.Log("we are logging ");
    }
}
