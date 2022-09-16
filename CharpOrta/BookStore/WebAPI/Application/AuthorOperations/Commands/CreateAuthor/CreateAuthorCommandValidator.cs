using System;
using FluentValidation;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator:AbstractValidator<CreateAuthorCommand>
    {
    public CreateAuthorCommandValidator()
    {
        RuleFor(command=> command.Model.FirstName).NotNull().NotEmpty().MinimumLength(2);
        RuleFor(command=> command.Model.LastName).NotNull().NotEmpty().MinimumLength(2);
        RuleFor(command=> command.Model.BirthOfDate).NotNull().NotEmpty().LessThan(DateTime.Now.Date);
    }        
    }
}