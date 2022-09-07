using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CountyValidator : AbstractValidator<County>
    {
        public CountyValidator()
        {
            RuleFor(p => p.CountyName).NotEmpty();

        }

    }
}
