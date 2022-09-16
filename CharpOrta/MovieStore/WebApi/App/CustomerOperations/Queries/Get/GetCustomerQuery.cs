using AutoMapper;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.CustomerOperations.Queries.Get
{
    public class GetCustomerQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetCustomerQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<CustomerQueryViewModel> Handle()
        {
            List<Customer> customers = _context.Customers.OrderBy(x => x.Id).ToList();            
            List<CustomerQueryViewModel> vm = _mapper.Map<List<CustomerQueryViewModel>>(customers);

            return vm;
        }

    }

    public class CustomerQueryViewModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}