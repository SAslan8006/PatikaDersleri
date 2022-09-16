using FluentValidation;

namespace WebApi.App.PurchasedMoviesOperation.Commands.Create
{
    public class CreatePurchaseMovieCommandValidator : AbstractValidator<CreatePurchaseMovieCommand>
    {
        public CreatePurchaseMovieCommandValidator()
        {
            RuleFor(command=> command.model.CustomerId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.model.MovieId).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}