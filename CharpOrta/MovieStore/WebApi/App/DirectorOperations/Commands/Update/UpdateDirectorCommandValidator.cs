using FluentValidation;

namespace WebApi.App.DirectorOperations.Commands.Update
{
    public class UpdateDirectorCommandValidator : AbstractValidator<UpdateDirectorCommand>
    {
        public UpdateDirectorCommandValidator()
        {
            RuleFor(command => command.model.Name).MinimumLength(1).NotNull().NotEmpty();
            RuleFor(command => command.model.SurName).MinimumLength(1).NotNull().NotEmpty();
            RuleFor(command => command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}