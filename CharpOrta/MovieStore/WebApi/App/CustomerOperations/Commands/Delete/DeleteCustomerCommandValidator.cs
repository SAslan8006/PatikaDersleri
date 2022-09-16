using FluentValidation;

namespace WebApi.App.CustomerOperations.Commands.Delete
{
    public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
        }
    }
}