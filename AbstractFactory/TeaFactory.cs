namespace Patterns.AbstractFactory
{
    public class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Prepare {amount} ml Tea");
            return new Tea();
        }
    }
}

