using FluentValidation;

namespace WebApi.App.DirectorMoviesOperation.Queries.GetDetail
{
    public class GetDirectorMovieDetailQueryValidator : AbstractValidator<GetDirectorMovieDetailQuery>
    {
        public GetDirectorMovieDetailQueryValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotEmpty().NotNull();
        }
    }
}