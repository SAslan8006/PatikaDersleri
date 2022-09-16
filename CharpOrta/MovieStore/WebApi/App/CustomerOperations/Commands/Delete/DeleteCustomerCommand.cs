using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.CustomerOperations.Commands.Delete
{
    public class DeleteCustomerCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int Id;

        public DeleteCustomerCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            Customer customer = _context.Customers.SingleOrDefault(x => x.Id == Id);
            if (customer is null)
                throw new InvalidOperationException("Silinmek istenen müşteri bulunamadı.");

            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}