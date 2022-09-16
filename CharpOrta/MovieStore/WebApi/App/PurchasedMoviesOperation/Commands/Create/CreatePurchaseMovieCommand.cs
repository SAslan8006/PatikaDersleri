using AutoMapper;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.PurchasedMoviesOperation.Commands.Create
{
    public class CreatePurchaseMovieCommand
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public PurchasedMoviesModel model;
        public CreatePurchaseMovieCommand(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var customer = _dbContext.Customers.SingleOrDefault(s => s.Id == model.CustomerId);
            var movies = _dbContext.Movies.SingleOrDefault(s => s.Id == model.MovieId);
            var purchasedMovie = _dbContext.PurchasedMovies.SingleOrDefault(s => s.CustomerId == model.CustomerId && s.MovieId == model.MovieId);

            if (customer is null)
                throw new InvalidOperationException("Müşteri bulunamadı!");
            else if (movies is null)
                throw new InvalidOperationException("Film bulunamadı!");
            else if (purchasedMovie is not null)
                throw new InvalidOperationException("Müşteri, daha önce bu filmi satın almış!");

            PurchasedMovies result = _mapper.Map<PurchasedMovies>(model);
            result.purchasedTime = DateTime.Now;
            result.movieStatus = true;

            _dbContext.PurchasedMovies.Add(result);
            _dbContext.SaveChanges();
        }
    }

    public class PurchasedMoviesModel
    {
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        DateTime purchasedTime = DateTime.Now;
        bool movieStatus = true;
    }
}