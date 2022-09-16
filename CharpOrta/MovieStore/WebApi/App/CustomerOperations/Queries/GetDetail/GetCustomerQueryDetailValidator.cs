using FluentValidation;


namespace WebApi.App.CustomerOperations.Queries.GetDetail
{
    public class GetCustomerQueryDetailValidator : AbstractValidator<GetCustomerQueryDetail>
    {
        public GetCustomerQueryDetailValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotEmpty().NotNull();
        }
    }
}