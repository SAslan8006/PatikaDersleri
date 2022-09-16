using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace WebApi.Entities
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthOfDate { get; set; } 
        public string FullName { get
        {
            return FirstName + " " + LastName;
        }
        }
        
        
    }
}