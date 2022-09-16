using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.CityId).NotEmpty();
            RuleFor(p => p.Adres).NotEmpty();
            RuleFor(p => p.BookId).NotEmpty();
            RuleFor(p => p.OrderDate).NotEmpty();

        }

    }
}
