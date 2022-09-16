using FluentValidation;

namespace WebApi.App.CustomerOperations.Commands.Update
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty().NotNull();
            RuleFor(command => command.Model.SurName).NotEmpty().NotNull();
            RuleFor(command => command.Model.Password).NotEmpty().NotNull();
            RuleFor(command => command.Model.Email).NotEmpty().NotNull().EmailAddress();
        }
    }
}