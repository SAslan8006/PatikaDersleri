using FluentValidation;

namespace WebApi.App.ActorMoviesOperation.Queries.GetDetail
{
    public class GetActorMoviesDetailQueryValidator : AbstractValidator<GetActorMoviesDetailQuery>
    {
        public GetActorMoviesDetailQueryValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotEmpty().NotNull();
        }
    }
}