using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>() 
        {
        new Book{Id=1,Title="Lean Startup",GenreId=1,PageCount=200,PublishDate=new DateTime(2001,06,12)},
        new Book{Id=2,Title="Herland",GenreId=2,PageCount=250,PublishDate=new DateTime(2010,05,23)},
        new Book{Id=3,Title="Dune",GenreId=2,PageCount=540,PublishDate=new DateTime(2001,12,21)}
        };
    }

    [HttpGet]
    public List<Book> GetBooks() 
    {
        var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
        return bookList;
    }


    [HttpGet]
    public Book  GetById()
    {
        var book = BookList.Where(book => book.Id).SingleOrDefault();
        return book;
    }
}
