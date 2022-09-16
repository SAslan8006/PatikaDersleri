using System;
using FluentValidation;
using WebApi.Common.Enums.GenreEnums;

namespace WebApi.App.MovieOperations.Commands.Create
{
    public class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEqual("string").MaximumLength(30).NotEmpty().NotNull();
            RuleFor(command => command.Model.GenreId).GreaterThan(0).NotEmpty().NotNull();
            RuleFor(command => command.Model.PublishDate).LessThan(DateTime.Now.Date).NotEmpty().NotNull();
            RuleFor(command => command.Model.Price).GreaterThan(0).NotEmpty().NotNull();
        }
    }
}