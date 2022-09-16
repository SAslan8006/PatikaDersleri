using FluentValidation;

namespace WebApi.App.FavoritesGenreOperations.Queries.GetDetail
{
    public class GetFavoritesGenreDetailQueryValidator : AbstractValidator<GetFavoritesGenreDetailQuery>
    {
        public GetFavoritesGenreDetailQueryValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}