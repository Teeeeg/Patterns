namespace Patterns.Singleton;

public class Singleton0
{
    private static Singleton0 instance = new Singleton0();

    private Singleton0()
    {

    }

    public static Singleton0 GetSingleton0()
    {
        return instance;
    }
}