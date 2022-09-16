using AutoMapper;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.FavoritesGenreOperations.Commands.Create
{
    public class CreateFavoriteGenresCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public FavoriteGenresModel model;
        public CreateFavoriteGenresCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        
        public void Handle()
        {
            var customer = _dbContext.Customers.SingleOrDefault(s => s.Id == model.CustomerId);
            var favoriteGenres  = _dbContext.FavoritesGenres.SingleOrDefault(s => s.CustomerId == model.CustomerId && s.FavoritesGenreId == model.FavoritesGenreId);

            if (customer is null)
                throw new InvalidOperationException("Müşteri bulunamadı!");
            else if (favoriteGenres is not null)
                throw new InvalidOperationException("Tür zaten favorilerde mevcut!");

            FavoritesGenre result = _mapper.Map<FavoritesGenre>(model);

            _dbContext.FavoritesGenres.Add(result);
            _dbContext.SaveChanges();
        }
    }

    public class FavoriteGenresModel
    {
        public int FavoritesGenreId { get; set; }
        public int CustomerId { get; set; }
    }
}