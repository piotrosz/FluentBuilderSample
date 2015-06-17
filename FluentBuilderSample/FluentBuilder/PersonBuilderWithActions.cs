using System;
using System.Collections.Generic;

namespace FluentBuilder
{
    public class PersonBuilderWithActions
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
            var person = Person.CreateEmpty();
            
            while (this.actions.Count > 0)
            {
                this.actions.Pop().Invoke(person);
            };
            
            return person;
        }
    }
}
