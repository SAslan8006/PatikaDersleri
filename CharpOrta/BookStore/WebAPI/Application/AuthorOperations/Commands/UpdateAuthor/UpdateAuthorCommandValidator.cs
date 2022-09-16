using System;
using FluentValidation;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandValidator : AbstractValidator<UpdateAuthorCommand>
    {
        public UpdateAuthorCommandValidator()
        {
            RuleFor(x => x.AuthorId).GreaterThan(0);
            RuleFor(command => command.Model.FirstName).NotNull().NotEmpty().MinimumLength(2);
            RuleFor(command => command.Model.LastName).NotNull().NotEmpty().MinimumLength(2);
            RuleFor(command => command.Model.BirthOfDate).NotNull().NotEmpty().LessThan(DateTime.Now.Date);
        }
    }
}