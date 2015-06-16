namespace FluentBuilder
{
    public class PersonBuilderWithImplicitCast
    {
        private string firstName;
        private string lastName;

        public PersonBuilderWithImplicitCast WithFirstName(string firstName)
        {
            this.firstName = firstName;
            return this;
        }

        public PersonBuilderWithImplicitCast WithLastName(string lastName)
        {
            this.lastName = lastName;
            return this;
        }

        public static implicit operator Person(PersonBuilderWithImplicitCast builder)
        {
            var person = Person.Empty;
            person.FirstName = builder.firstName;
            person.LastName = builder.lastName;
            return person;
        }
    }
}
