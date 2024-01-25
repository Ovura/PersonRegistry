namespace PersonRegistry
{
    class Child : Person
    {

        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public override string GetName()
        {
            return "Child." + this.FirstName + " " + this.LastName;
        }

        public static Child operator +(Child a, Child b)
        {
            Child c1 = new Child
            {
                FirstName = a.FirstName,
                LastName = b.LastName
            };
            return c1;
        }


    };


}


