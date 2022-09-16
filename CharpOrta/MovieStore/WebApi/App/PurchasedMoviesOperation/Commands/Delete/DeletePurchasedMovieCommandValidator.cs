using FluentValidation;

namespace WebApi.App.PurchasedMoviesOperation.Commands.Delete
{
    public class DeletePurchasedMovieCommandValidator : AbstractValidator<DeletePurchasedMovieCommand>
    {
        public DeletePurchasedMovieCommandValidator()
        {            
            RuleFor(command=> command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}