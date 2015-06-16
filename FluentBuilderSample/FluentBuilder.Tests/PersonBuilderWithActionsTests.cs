using FluentAssertions;
using Xunit;

namespace FluentBuilder.Tests
{
    public class PersonBuilderWithActionsTests
    {
        [Fact]
        public void ShouldBuildPersonWithFirstNameAndLastName()
        {
            const string firstName = "Jan";
            const string lastName = "Kowalski";

            var result = new PersonBuilderWithActions()
                .WithFirstName(firstName)
                .WithLastName(lastName)
                .Build();

            result.FirstName.Should().Be(firstName);
            result.LastName.Should().Be(lastName);
        }

        [Fact]
        public void ShouldBuildEmptyPerson()
        {
            var result = new PersonBuilderWithActions()
                .Build();

            result.FirstName.Should().BeNull();
            result.LastName.Should().BeNull();
        }
    }
}
