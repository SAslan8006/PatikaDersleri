using FluentValidation;

namespace WebApi.App.FavoritesGenreOperations.Commands.Create
{
    public class CreateFavoriteGenresCommandValidator : AbstractValidator<CreateFavoriteGenresCommand>
    {
        public CreateFavoriteGenresCommandValidator()
        {
            RuleFor(command=> command.model.CustomerId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.model.FavoritesGenreId).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}