using FluentAssertions;
using Xunit;

namespace FluentBuilder.Tests
{
    public class PersonBuilderWithImplicitCastTests
    {
        [Fact]
        public void ShouldBuildPersonWithFirstNameAndLastName()
        {
            const string firstName = "Jan";
            const string lastName = "Kowalski";

            Person person = new PersonBuilderWithImplicitCast()
                .WithFirstName(firstName)
                .WithLastName(lastName);

            person.FirstName.Should().Be(firstName);
            person.LastName.Should().Be(lastName);
        }
    }
}
