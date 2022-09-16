using System.ComponentModel;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.FavoritesGenreOperations.Queries.Get
{
    public class GetFavoritesGenreQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetFavoritesGenreQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _dbContext = context;
            _mapper = mapper;
        }

        public List<FavoritesGenreQueryViewModel> Handle()
        {
            List<Customer> list = _dbContext.Customers.Include(i => i.FavoritesGenres).OrderBy(x => x.Id).ToList();
            List<FavoritesGenreQueryViewModel> vm = _mapper.Map<List<FavoritesGenreQueryViewModel>>(list);

            return vm;
        }
    }

    public class FavoritesGenreQueryViewModel
    {
        public string NameSurname { get; set; }
        public IReadOnlyList<string> Genres { get; set; }
    }
}