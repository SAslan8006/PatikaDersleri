using FluentValidation;

namespace WebApi.App.ActorOperations.Queries.GetDetail
{
    public class GetActorsDetailQueryValidator : AbstractValidator<GetActorsDetailQuery>
    {
        public GetActorsDetailQueryValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotEmpty().NotNull();
        }
    }
}