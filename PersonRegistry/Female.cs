namespace PersonRegistry
{
    class Female : Person
    {

        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public override string GetName()
        {

            return "Miss. " + this.FirstName +" "+ this.LastName;
        }


    }
}
