using FluentAssertions;
using Xunit;

namespace FluentBuilder.Tests
{
    public class PersonBuilderTests
    {
        [Fact]
        public void ShouldBuildPersonWithFirstNameAndLastNameAndAge()
        {
            const string firstName = "Jan";
            const string lastName = "Kowalski";
            const int age = 67;

            var result = new PersonBuilder(firstName)
                .WithLastName(lastName)
                .OfAge(67)
                .Person;

            result.FirstName.Should().Be(firstName);
            result.LastName.Should().Be(lastName);
            result.Age.Should().Be(age);
        }
    }
}
