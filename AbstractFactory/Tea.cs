namespace Patterns.AbstractFactory;

public class Tea : IHotDrink
{

    public void Consume()
    {
        Console.WriteLine("Drinking Tea");
    }
}

