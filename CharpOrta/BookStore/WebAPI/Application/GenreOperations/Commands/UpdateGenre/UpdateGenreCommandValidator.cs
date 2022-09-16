using FluentValidation;

namespace WebApi.Application.GenreOperation.Commands.UpdateGenre
{
    public class UpdateGenreCommandValidator : AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreCommandValidator()
        {
            RuleFor(command=> command.GenreId).NotEmpty().NotNull().GreaterThan(0);
            RuleFor(command=> command.Model.Name).NotNull().MinimumLength(4).When(x=> x.Model.Name != string.Empty);
        }
    }
}