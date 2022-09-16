using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BookImageValidator : AbstractValidator<BookImage>
    {
        public BookImageValidator()
        {
            RuleFor(c => c.BookId).NotEmpty();
            RuleFor(c => c.ImagePath).NotEmpty();
            RuleFor(c => c.ImagePath).MinimumLength(2);
        }
    }
}
