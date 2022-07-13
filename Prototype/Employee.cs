namespace Patterns.Prototype
{
    public class Employee : Person, IDeepCopyable<Employee>
    {
        public int salary { get; set; }

        public Employee()
        {
        }

        public Employee(int salary) : base()
        {
            this.salary = salary;
        }

        public void CopyTo(Employee target)
        {
            base.CopyTo(target);
            target.salary = salary;
        }


        public override string ToString()
        {
            return base.ToString() + " " + $"{nameof(salary)}: {salary}";
        }
    }


}

