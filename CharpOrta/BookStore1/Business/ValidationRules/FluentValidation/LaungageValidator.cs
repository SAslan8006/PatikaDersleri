using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class LaungageValidator : AbstractValidator<Laungage>
    {
        public LaungageValidator()
        {
            RuleFor(p => p.BookLaungage).NotEmpty();

        }

    }
}
