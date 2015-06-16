using System;
using System.Collections.Generic;

namespace FluentBuilder
{
    public class PersonBuilderWithActions : IFluentInterface
    {
        private readonly Stack<Action<Person>> actions;

        public PersonBuilderWithActions()
        {
            this.actions = new Stack<Action<Person>>();
        }

        public PersonBuilderWithActions WithFirstName(string firstName)
        {
            actions.Push(p => p.FirstName = firstName);
            return this;
        }

        public PersonBuilderWithActions WithLastName(string lastName)
        {
            actions.Push(p => p.LastName = lastName);
            return this;
        }

        public Person Build()
        {
            var person = new Person();

            do
            {
                this.actions.Pop().Invoke(person);
            }
            while (actions.Count > 0);
            

            return person;
        }
    }
}
