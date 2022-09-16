using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.App.DirectorOperations.Queries.Get;
using WebApi.App.PurchasedMoviesOperation.Queries.Get;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.PurchasedMoviesOperation.Queries.GetDetail
{
    public class GetPurchasedMoviesDetailQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int Id;

        public GetPurchasedMoviesDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public PurchasedMoviesViewModel Handle()
        {
            Customer customer = _dbContext.Customers.Include(i => i.PurchasedMovies).ThenInclude(t => t.Movie).SingleOrDefault(s => s.Id == Id);
            PurchasedMoviesViewModel vm = _mapper.Map<PurchasedMoviesViewModel>(customer);

            return vm;
        }
    }

    
}