using FluentAssertions;
using WebApi.Application.BookOperations.Commands.DeleteBook;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Commands.DeleteBook
{
    public class DeleteBookValidatorTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        public void WhenInvalidInputAreGiven_Validator_ShouldBeReturnErrors(int bookId)
        {
            DeleteBookCommand command = new DeleteBookCommand(null);
            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            command.BookId = bookId;

            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError()
        {
            DeleteBookCommand command = new DeleteBookCommand(null);
            DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
            command.BookId = 1;

            var result = validator.Validate(command);
            result.Errors.Count.Should().Equals(0);
        }
    }
}