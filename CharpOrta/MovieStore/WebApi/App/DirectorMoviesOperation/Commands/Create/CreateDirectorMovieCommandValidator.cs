using FluentValidation;

namespace WebApi.App.DirectorMoviesOperation.Commands.Create
{
    public class CreateDirectorMovieCommandValidator : AbstractValidator<CreateDirectorMovieCommand>
    {
        public CreateDirectorMovieCommandValidator()
        {
            RuleFor(command=> command.model.DirectorId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.model.MovieId).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}