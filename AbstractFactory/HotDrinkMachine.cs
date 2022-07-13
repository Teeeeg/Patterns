namespace Patterns.AbstractFactory
{
    public class HotDrinkMachine
    {
        private List<Tuple<string, IHotDrinkFactory?>> factories = new List<Tuple<string, IHotDrinkFactory?>>();

        public HotDrinkMachine()
        {
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if (typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        Activator.CreateInstance(t) as IHotDrinkFactory));
                }
            }
        }

        public IHotDrink? MakeDrink()
        {
            Console.WriteLine("Avaliable Drinks");

            for (int i = 0; i < factories.Count; i++)
            {
                var tup = factories[i];
                Console.WriteLine($"{i}: {tup.Item1}");
            }

            while (true)
            {
                string? s = Console.ReadLine();
                if (s != null && int.TryParse(s, out int i) && i >= 0 && i < factories.Count)
                {
                    Console.WriteLine("Specify amount");
                    s = Console.ReadLine();
                    if (s != null && int.TryParse(s, out int amount) && amount > 0)
                    {
                        return factories[i].Item2?.Prepare(amount);
                    }
                }
                Console.WriteLine("Incorrect input, try again");
            }
        }
    }
}

