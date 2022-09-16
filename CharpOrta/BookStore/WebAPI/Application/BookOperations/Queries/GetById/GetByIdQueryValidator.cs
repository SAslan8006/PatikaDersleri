using FluentValidation;

namespace WebApi.Application.BookOperations.Queries.GetById
{
    public class GetByIdQueryValidator:AbstractValidator<GetByIdQuery>
    {
        public GetByIdQueryValidator()
        {
            RuleFor(query=>query.BookId).GreaterThan(0);
        }
    }
}