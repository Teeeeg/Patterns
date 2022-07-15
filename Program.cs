using Patterns.BuilderPattern;

namespace Patterns;
public class Program
{

    public static void Main(string[] args)
    {
        var director = new Director();
        var builder = new ConcreteBuilder();
        director.Builder = builder;

        System.Console.WriteLine("Standard Basic Product");
        director.BuildMinimalViableProduct();
        System.Console.WriteLine(builder.GetProduct().ListParts());

        System.Console.WriteLine("Standard full Product");
        director.BuildFeatureProdcut();
        System.Console.WriteLine(builder.GetProduct().ListParts());

        System.Console.WriteLine("Custom Build");
        builder.BuildPartA();
        builder.BuildPartC();
        System.Console.WriteLine(builder.GetProduct().ListParts());
    }
}