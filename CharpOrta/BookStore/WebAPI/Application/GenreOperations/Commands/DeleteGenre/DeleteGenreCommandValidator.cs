using FluentValidation;

namespace WebApi.Application.GenreOperation.Commands.DeleteGenre
{
    public class DeleteGenreCommandValidator : AbstractValidator<DeleteGenreCommand>
    {
        public DeleteGenreCommandValidator()
        {
            RuleFor(command=> command.GenreId).NotEmpty().NotNull().GreaterThan(0);
        }
    }
}