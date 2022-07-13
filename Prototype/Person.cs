namespace Patterns.Prototype
{

    public class Person : IDeepCopyable<Person>
    {
        public string[] names { get; set; }
        public Address address { get; set; }

        public Person()
        {

        }

        public Person(string[] names, Address address)
        {
            this.names = names;
            this.address = address;
        }

        public Person(Person other)
        {
            names = other.names;
            address = new Address(other.address);

        }
        public override string ToString()
        {
            return $"{nameof(names)}: {string.Join(" ", names)}, {nameof(address)}: {address}";
        }

        public void CopyTo(Person target)
        {
            target.names = (string[])names.Clone();
            target.address = address.DeepCopy();
        }
    }


}

