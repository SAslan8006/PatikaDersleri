using System;
using FluentAssertions;
using WebApi.Application.BookOperations.Commands.UpdateBook;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Commands.UpdateBook
{
    public class UpdateBookValidatorTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        public void WhenInvalidInputAreGivens_Validator_ShouldBeReturnErrors(int bookId)
        {
            UpdateBookCommand command = new UpdateBookCommand(null);
            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            command.Model = new UpdateBookModel()
            {
                Title = "",
                PageCount = 0,
                GenreId = 0,
                AuthorId =0
            };
            command.BookId = bookId;
            var result = validator.Validate(command);
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnError()
        {
            UpdateBookCommand command = new UpdateBookCommand(null);
            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            command.BookId = 1;
            command.Model = new UpdateBookModel()
            {
                Title = "Lord Of The Rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date.AddYears(-2),
                GenreId = 1,
                AuthorId = 1
            };

            var result = validator.Validate(command);
            result.Errors.Count.Should().Equals(0);
        }
    }
}