using System.ComponentModel.DataAnnotations;

namespace WebApi.Entites
{
    public class PurchasedMovies
    {
        [Key]
        public int Id { get; set; }
        public bool movieStatus { get; set; }
        public DateTime purchasedTime { get; set;}
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}