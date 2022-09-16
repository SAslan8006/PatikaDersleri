using AutoMapper;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetails;
using WebApi.Application.AuthorOperations.Queries.GetAuthors;
using WebApi.Application.BookOperations.Commands.CreateBook;
using WebApi.Application.BookOperations.Queries.GetBooks;
using WebApi.Application.BookOperations.Queries.GetById;
using WebApi.Application.GenreOperation.Commands.CreateGenre;
using WebApi.Application.GenreOperation.Queries.GetGenreDetail;
using WebApi.Application.GenreOperation.Queries.GetGenres;
using WebApi.Entities;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Book
            CreateMap<CreateBookModel, Book>();
            CreateMap<Book, BookViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name)).
            ForMember(dest => dest.Author, opt=> opt.MapFrom(src=>src.Author.FullName));
            CreateMap<Book, BooksViewModel>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => src.Genre.Name)).
            ForMember(dest => dest.Author, opt=> opt.MapFrom(src=>src.Author.FullName));

            //Genre
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GenreDetailViewModel>();

            //Author
            CreateMap<Author, GetAllAuthorsViewModel>().ForMember(dest => dest.BirthOfDate, opt => opt.MapFrom(src => src.BirthOfDate.ToString("dd.MM.yyyy")));
            CreateMap<Author, GetAuthorDetailsViewModel>().ForMember(dest => dest.BirthOfDate, opt => opt.MapFrom(src => src.BirthOfDate.ToString("dd.MM.yyyy")));
            CreateMap<CreateAuthorModel, Author>();
            
        }
    }
}