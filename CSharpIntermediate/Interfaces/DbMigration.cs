

namespace CSharpIntermediate;

public class DbMigration
{
    private readonly ILogger logger;

    public DbMigration(ILogger logger)
    {
        this.logger = logger;
    }
    public void Migrate()
    {
        logger.LogInfo("migration started " + DateTime.Now);

        logger.LogError("migration ended" + DateTime.Today.AddHours(1));
    }
}
