using FluentValidation;
using WebApi.App.MovieOperations.Queries.Get;

namespace WebApi.App.MovieOperations.Queries.GetDetail
{
    public class GetMovieDetailQueryValidator : AbstractValidator<GetMovieDetailQuery>
    {
        public GetMovieDetailQueryValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotEmpty().NotNull();
        }
    }
}