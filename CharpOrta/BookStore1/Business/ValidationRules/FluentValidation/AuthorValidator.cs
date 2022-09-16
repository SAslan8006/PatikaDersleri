using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(p => p.AuthorFirstName).NotEmpty();
            RuleFor(p => p.AuthorLastName).NotEmpty();

        }

    }
}
