using System.ComponentModel.DataAnnotations;

namespace WebApi.Entites
{
    public class FavoritesGenre
    {
        [Key]
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int FavoritesGenreId { get; set; }
    }
}