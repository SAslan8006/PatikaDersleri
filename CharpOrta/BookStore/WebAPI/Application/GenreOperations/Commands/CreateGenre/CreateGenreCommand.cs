using System.Linq;
using System;
using WebApi.Entities;
using WebApi.DBOperations;
using AutoMapper;

namespace WebApi.Application.GenreOperation.Commands.CreateGenre
{
    public class CreateGenreCommand
    {
        public CreateGenreModel Model { get;set; }
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateGenreCommand(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var genre =_context.Genres.SingleOrDefault(x=>x.Name == Model.Name);
            if (genre != null)
                throw new InvalidOperationException("Kitap Türü Zaten Mevcut");

            genre = new Genre();
            genre.Name = Model.Name;
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

    }


    public class CreateGenreModel
    {
        public string Name { get; set; }
    }
}