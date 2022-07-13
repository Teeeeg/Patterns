namespace Patterns.Prototype
{
    public class Address : IDeepCopyable<Address>
    {
        public string street { get; set; }
        public int houseNumber { get; set; }

        public Address()
        {

        }

        public Address(string street, int houseNumber)
        {
            this.street = street;
            this.houseNumber = houseNumber;
        }

        public Address(Address other)
        {
            street = other.street;
            houseNumber = other.houseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(street)}: {street}, {nameof(houseNumber)}: {houseNumber}";
        }

        public void CopyTo(Address target)
        {
            target.street = street;
            target.houseNumber = houseNumber;
        }
    }


}

