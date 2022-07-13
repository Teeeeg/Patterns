namespace Patterns.AbstractFactory
{
    public class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Prepare {amount} ml Coffee");
            return new Coffee();
        }
    }
}

