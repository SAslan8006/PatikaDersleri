using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Book:IEntity
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public int PageNumber { get; set; }
        public decimal Price { get; set; }
        public string IsbnNo { get; set; }
        public string About { get; set; }
        public int Stock { get; set; }
        public int CargoId { get; set; }
        public int BookLanguageId { get; set; }
    }
}
