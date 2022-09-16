using FluentAssertions;
using WebApi.Application.BookOperations.Queries.GetById;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Queries.GetBookById
{
    public class GetBookDetailQueryValidatorTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-2)]
        [InlineData(-3)]
        public void WhenInvalidInputAreGiven_Validator_ShouldBeReturnErrors(int bookId)
        {
            GetByIdQuery query = new GetByIdQuery(null,null);
            GetByIdQueryValidator validator = new GetByIdQueryValidator();
            query.BookId = bookId;

            var result = validator.Validate(query);

            result.Errors.Count.Should().BeGreaterThan(0);
        }
    }
}