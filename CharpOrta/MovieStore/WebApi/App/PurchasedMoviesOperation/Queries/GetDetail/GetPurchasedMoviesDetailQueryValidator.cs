using FluentValidation;

namespace WebApi.App.PurchasedMoviesOperation.Queries.GetDetail
{
    public class GetPurchasedMoviesDetailQueryValidator : AbstractValidator<GetPurchasedMoviesDetailQuery>
    {
        public GetPurchasedMoviesDetailQueryValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}