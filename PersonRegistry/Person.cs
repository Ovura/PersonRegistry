using System;

namespace PersonRegistry
{
    public abstract class Person : IComparable<Person>
    {
        public abstract string FirstName { get; set; }

        public abstract string LastName { get; set; }

        public int CompareTo(Person other) =>
            (this.FirstName, this.LastName).CompareTo((other.FirstName, other.LastName));
        
        public abstract string GetName();

    }
}
