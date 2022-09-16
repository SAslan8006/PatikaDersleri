using FluentValidation;

namespace WebApi.App.FavoritesGenreOperations.Commands.Delete
{
    public class DeleteFavoriteGenresCommandValidator : AbstractValidator<DeleteFavoriteGenresCommand>
    {
        public DeleteFavoriteGenresCommandValidator()
        {            
            RuleFor(command=> command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}