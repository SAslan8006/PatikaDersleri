using FluentValidation;

namespace WebApi.App.PurchasedMoviesOperation.Commands.Update
{
    public class UpdatePurchaseMovieCommandValidator : AbstractValidator<UpdatePurchaseMovieCommand>
    {
        public UpdatePurchaseMovieCommandValidator()
        {
            RuleFor(command=> command.model.CustomerId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.model.MovieId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}