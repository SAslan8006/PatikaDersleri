using FluentValidation;

namespace WebApi.App.MovieOperations.Commands.Delete
{
    public class DeleteMovieCommandValidator : AbstractValidator<DeleteMovieCommand>
    {
        public DeleteMovieCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0).NotEmpty().NotNull();
        }
    }
}