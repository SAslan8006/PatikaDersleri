using FluentValidation;

namespace WebApi.App.DirectorOperations.Commands.Delete
{
    public class DeleteDirectorCommandValidator : AbstractValidator<DeleteDirectorCommand>
    {
        public DeleteDirectorCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}