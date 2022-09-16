using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;
using WebApi.Entities;

namespace WebApi.Application.BookOperations.Commands.CreateBook
{

    public class CreateBookCommand
    {
        public CreateBookModel Model { get; set; }
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;

        public CreateBookCommand(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(x => x.Title == Model.Title);
            if (book is not null)
                throw new InvalidOperationException("Kitap Zaten Mevcut");
            book = _mapper.Map<Book>(Model);
            //new Book();
            // book.Title = Model.Title;
            // book.GenreId = Model.GenreId;
            // book.PageCount = Model.PageCount;
            // book.PublishDate = Model.PublishDate;

            _context.Books.Add(book);
            _context.SaveChanges();

        }
    }
    public class CreateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int AuthorId{get;set;}
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }



    }
}