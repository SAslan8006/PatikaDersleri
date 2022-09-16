using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebApi.Common.Enums.GenreEnums;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.MovieOperations.Queries.Get
{
    public class GetMovieQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetMovieQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<MovieQueryViewModel> Handle()
        {
            List<Movie> movies = _context.Movies.Include(i => i.ActorMovies).ThenInclude(t=> t.Actor).Include(i => i.DirectorMovies).ThenInclude(t=> t.Director).OrderBy(x=> x.Id).ToList();                    
            List<MovieQueryViewModel> vm = _mapper.Map<List<MovieQueryViewModel>>(movies);
            
            return vm;
        }
    }

    public class MovieQueryViewModel
    {
        public string Name { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }        
        public IReadOnlyCollection<string> Director { get; set; }
        public IReadOnlyList<string> Actors { get; set; }
        public int Price { get; set; }
    }
}