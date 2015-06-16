using System;

namespace FluentBuilder
{
    public class PersonBuilder : IFluentInterface
    {
        private Lazy<Person> person;

        public PersonBuilder()
        {
            this.person = new Lazy<Person>(() => new Person());
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            this.person.Value.FirstName = firstName;
            return this;
        }

        public PersonBuilder WithLastName(string lastName)
        {
            this.person.Value.LastName = lastName;
            return this;
        }

        public Person Build()
        {
            return this.person.Value;
        }
    }
}
