using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>() {
        new Book{
            Id=1,
            Title"Lean Startup",
        }
        };
    }

}
