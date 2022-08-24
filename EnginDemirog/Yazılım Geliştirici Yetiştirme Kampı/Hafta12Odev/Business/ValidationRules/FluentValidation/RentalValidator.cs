using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.Amount).GreaterThan(0);
        }

    }
}