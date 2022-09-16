using AutoMapper;
using WebApi.App.CustomerOperations.Queries.Get;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.CustomerOperations.Queries.GetDetail
{
    public class GetCustomerQueryDetail
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public int Id { get; set; }

        public GetCustomerQueryDetail(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CustomerQueryViewModel Handle()
        {
            Customer customer = _context.Customers.SingleOrDefault(x => x.Id == Id);
            if (customer is null)
                throw new InvalidOperationException("Müşteri mevcut değil.");
            
            CustomerQueryViewModel vm = _mapper.Map<CustomerQueryViewModel>(customer);

            return vm;
        }
    }
}