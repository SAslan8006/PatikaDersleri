using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.App.DirectorMoviesOperation.Commands.Create;
using WebApi.App.FavoritesGenreOperations.Commands.Create;
using WebApi.App.PurchasedMoviesOperation.Commands.Create;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.FavoritesGenreOperations.Commands.Update
{
    public class UpdateFavoriteGenresCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public UpdateFavoriteGenresModel model;
        public int Id;
        public UpdateFavoriteGenresCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var favoriteGenres = _dbContext.FavoritesGenres.SingleOrDefault(s => s.Id == Id);
            var customerFavoriteGenresList = _dbContext.FavoritesGenres.Where(s => s.Id == favoriteGenres.CustomerId);
            bool checkGenre = false;

            foreach (var item in customerFavoriteGenresList)
            {
                var result = item.FavoritesGenreId;
                checkGenre = result == model.FavoritesGenreId ? true : false;
            }
            
            if (checkGenre)
                throw new InvalidOperationException("Tür zaten favorilerde mevcut!");
            else if(favoriteGenres is null)
                throw new InvalidOperationException("ilgili kayda ait veri bulunamadı.");

            favoriteGenres.FavoritesGenreId = model.FavoritesGenreId == default ? favoriteGenres.FavoritesGenreId : model.FavoritesGenreId;

            _dbContext.FavoritesGenres.Update(favoriteGenres);
            _dbContext.SaveChanges();
        }

        public class UpdateFavoriteGenresModel
        {
            public int FavoritesGenreId { get; set; }
        }
    }
}