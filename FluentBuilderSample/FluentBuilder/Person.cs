namespace FluentBuilder
{
    public class Person
    {
        private Person() { }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public bool IsActive { get; set; } = false;

        public static Person CreateEmpty() => new Person();
    }
}
