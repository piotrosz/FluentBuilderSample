namespace FluentBuilder
{
    public class PersonBuilderWithImplicitCast : IFluentInterface
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
            return new Person
            {
                FirstName = builder.firstName,
                LastName = builder.lastName
            };
        }
    }
}
