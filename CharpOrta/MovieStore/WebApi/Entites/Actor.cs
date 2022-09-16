using System.ComponentModel.DataAnnotations;

namespace WebApi.Entites
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public virtual ICollection<ActorMovies> ActorMovies { get; set; }
    }
}


