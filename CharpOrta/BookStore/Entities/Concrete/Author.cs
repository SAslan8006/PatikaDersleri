using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Author:IEntity
    {
        public int Id { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }        
        public string AuthorAbout { get; set; }

    }
}
