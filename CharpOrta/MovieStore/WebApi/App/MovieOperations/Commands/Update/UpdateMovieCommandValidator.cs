using FluentValidation;

namespace WebApi.App.MovieOperations.Commands.Update
{
    public class UpdateMovieCommandValidator : AbstractValidator<UpdateMovieCommand>
    {
        public UpdateMovieCommandValidator()
        {
            RuleFor(command => command.Id).GreaterThan(0).NotNull().NotEmpty();
            RuleFor(command => command.Model.Name).MaximumLength(30);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.PublishDate).LessThan(DateTime.Now.Date);
            RuleFor(command => command.Model.Price).GreaterThan(0);
        }
    }
}