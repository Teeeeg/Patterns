using Patterns.AbstractFactory;
using Patterns.Prototype;

namespace Patterns;


public class Program
{
    public static void Main(string[] args)
    {
        Employee john = new Employee();
        john.names = new string[] { "John", "Smith" };
        john.address = new Address("London Road", 123);
        john.salary = 123000;


        var jane = john.DeepCopy();
        jane.address.houseNumber = 321;
        Console.WriteLine(john);
        Console.WriteLine(jane);
    }
}