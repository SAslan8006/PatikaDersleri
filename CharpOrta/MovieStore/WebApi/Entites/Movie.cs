using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace WebApi.Entites
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public int GenreId { get; set; }
        public int Price { get; set; }
        public virtual ICollection<ActorMovies> ActorMovies { get; set; }
        public virtual ICollection<DirectorMovies> DirectorMovies { get; set; }
    }
}