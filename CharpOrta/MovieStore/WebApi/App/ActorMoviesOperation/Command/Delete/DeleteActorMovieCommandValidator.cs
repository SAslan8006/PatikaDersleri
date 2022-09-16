using FluentValidation;

namespace WebApi.App.ActorMoviesOperation.Command.Delete
{
    public class DeleteActorMovieCommandValidator : AbstractValidator<DeleteActorMovieCommand>
    {
        public DeleteActorMovieCommandValidator()
        {            
            RuleFor(command=> command.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}