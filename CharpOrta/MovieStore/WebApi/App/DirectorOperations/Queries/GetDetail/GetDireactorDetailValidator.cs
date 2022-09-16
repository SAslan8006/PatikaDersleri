using FluentValidation;

namespace WebApi.App.DirectorOperations.Queries.GetDetail
{
    public class GetDirectorDetailValidator : AbstractValidator<GetDirectorQueryDetail>
    {
        public GetDirectorDetailValidator()
        {
            RuleFor(query => query.Id).GreaterThan(0).NotNull().NotEmpty();
        }
    }
}