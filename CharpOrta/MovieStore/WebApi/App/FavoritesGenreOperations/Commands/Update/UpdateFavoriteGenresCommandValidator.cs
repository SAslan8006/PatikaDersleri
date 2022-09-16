using FluentValidation;
using WebApi.App.PurchasedMoviesOperation.Commands.Update;

namespace WebApi.App.FavoritesGenreOperations.Commands.Update
{
    public class UpdateFavoriteGenresCommandValidator : AbstractValidator<UpdateFavoriteGenresCommand>
    {
        public UpdateFavoriteGenresCommandValidator()
        {
            RuleFor(command=> command.model.FavoritesGenreId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}