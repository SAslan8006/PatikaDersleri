using FluentValidation;

namespace WebApi.App.ActorOperations.Commands.Update
{
    public class UpdateActorCommandValidator : AbstractValidator<UpdateActorCommand>
    {
        public UpdateActorCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty().NotNull();
            RuleFor(command => command.Model.SurName).NotEmpty().NotNull();
        }
    }
}