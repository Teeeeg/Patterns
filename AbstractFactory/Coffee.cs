using System;
namespace Patterns.AbstractFactory
{
    public class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Drinking Coffee");
        }
    }
}

