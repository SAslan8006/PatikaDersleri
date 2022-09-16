using FluentValidation;

namespace WebApi.Application.GenreOperation.Commands.CreateGenre
{
    public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(command=> command.Model.Name).MinimumLength(4);
        }
    }
}