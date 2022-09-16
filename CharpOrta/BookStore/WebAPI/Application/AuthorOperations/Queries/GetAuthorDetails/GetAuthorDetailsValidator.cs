using FluentValidation;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetails
{
    public class GetAuthorDetailsValidator:AbstractValidator<GetAuthorDetailsQuery>
    {
         public GetAuthorDetailsValidator()
         {
             RuleFor(query=>query.AuthorId).GreaterThan(0);
         }
    }
}