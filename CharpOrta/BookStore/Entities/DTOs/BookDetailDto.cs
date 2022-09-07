using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BookDetailDto:IDto
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public int PageNumber { get; set; }
        public decimal Price { get; set; }
        public string IsbnNo { get; set; }
        public string About { get; set; }
        public int Stock { get; set; }
        public int CargoId { get; set; }
        public string CargoName { get; set; }
        public int BookLanguageId { get; set; }
        public string BookLaungage { get; set; }
        public List<BookImage> BookImages { get; set; }

    }
}
