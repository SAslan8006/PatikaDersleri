using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.App.DirectorOperations.Queries.Get;
using WebApi.App.FavoritesGenreOperations.Queries.Get;
using WebApi.App.PurchasedMoviesOperation.Queries.Get;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.FavoritesGenreOperations.Queries.GetDetail
{
    public class GetFavoritesGenreDetailQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int Id;

        public GetFavoritesGenreDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public FavoritesGenreQueryViewModel Handle()
        {
            Customer customer = _dbContext.Customers.Include(i => i.FavoritesGenres).SingleOrDefault(s => s.Id == Id);
            FavoritesGenreQueryViewModel vm = _mapper.Map<FavoritesGenreQueryViewModel>(customer);

            return vm;
        }
    }
}