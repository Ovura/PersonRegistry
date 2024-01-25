namespace PersonRegistry
{
    class Male : Person
    {
        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public override string GetName()
        {

            return "Mr. " + this.FirstName +" "+ this.LastName;
        }


    }
}
