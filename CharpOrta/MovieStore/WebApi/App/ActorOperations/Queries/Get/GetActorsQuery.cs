using System.ComponentModel;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.ActorOperations.Queries.Get
{
    public class GetActorsQuery
    {
        private readonly IMovieStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetActorsQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<GetActorsQueryViewModel> Handle()
        {
            List<Actor> actors = _context.Actors.OrderBy(x => x.Id).ToList();            
            List<GetActorsQueryViewModel> vm = _mapper.Map<List<GetActorsQueryViewModel>>(actors);

            return vm;
        }

    }

    public class GetActorsQueryViewModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }

}