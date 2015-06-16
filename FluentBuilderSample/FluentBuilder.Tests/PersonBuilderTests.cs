using FluentAssertions;
using Xunit;

namespace FluentBuilder.Tests
{
    public class PersonBuilderTests
    {
        [Fact]
        public void ShouldBuildPersonWithFirstNameAndLastName()
        {
            const string firstName = "Jan";
            const string lastName = "Kowalski";

            var result = new PersonBuilder()
                .WithFirstName(firstName)
                .WithLastName(lastName)
                .Build();

            result.FirstName.Should().Be(firstName);
            result.LastName.Should().Be(lastName);
        }
    }
}
