using System.ComponentModel.DataAnnotations;

namespace WebApi.Entites
{
    public class DirectorMovies
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }
    }
}