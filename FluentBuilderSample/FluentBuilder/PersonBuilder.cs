﻿using System;

namespace FluentBuilder
{
    public class PersonBuilder
    {
        private Lazy<Person> person;

        public PersonBuilder(string firstName)
        {
            this.person = new Lazy<Person>(() => 
                {
                    var person = Person.CreateEmpty();
                    person.FirstName = firstName;
                    return person;
                });
        }

        public PersonBuilder WithLastName(string lastName)
        {
            this.person.Value.LastName = lastName;
            return this;
        }

        public PersonBuilder OfAge(int age)
        {
            if(age < 0)
            {
                throw new ArgumentOutOfRangeException("age", "age cannot be negative");
            }

            this.person.Value.Age = age;

            return this;
        }

        public Person Person => this.person.Value;
    }
}
