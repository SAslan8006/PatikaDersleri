using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BookImage : IEntity
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date { get; set; }
    }
}
