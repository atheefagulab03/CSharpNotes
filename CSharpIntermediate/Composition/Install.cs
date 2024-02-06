namespace CSharpIntermediate;

public class Install(Logger logger)
{
    private readonly Logger logger = logger;

    public void Instal()
    {
        logger.Log("we are installing");
    }
}
