using FluentValidation;

namespace WebApi.App.ActorOperations.Commands.Delete
{
    public class DeleteActorCommandValidator : AbstractValidator<DeleteActorCommand>
    {
        public DeleteActorCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}