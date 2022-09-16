using FluentValidation;

namespace WebApi.App.DirectorMoviesOperation.Commands.Update
{
    public class UpdateDirectorMovieCommandValidator : AbstractValidator<UpdateDirectorMovieCommand>
    {
        public UpdateDirectorMovieCommandValidator()
        {
            RuleFor(command=> command.model.DirectorId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.model.MovieId).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command=> command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}