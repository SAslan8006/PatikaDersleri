using System.ComponentModel.DataAnnotations;

namespace WebApi.Entites
{
    public class ActorMovies
    {
        [Key]
        public int Id { get; set; }        
        public int MovieId { get; set; }        
        public virtual Movie Movie { get; set; }
        public int ActorId { get; set; }
        public virtual Actor Actor { get; set; }
    }
}