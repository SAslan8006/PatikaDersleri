using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.ActorOperations.Commands.Delete
{
    public class DeleteActorCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int Id;

        public DeleteActorCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public void Handle()
        {
            Actor actor = _context.Actors.SingleOrDefault(x => x.Id == Id);
            if (actor is null)
                throw new InvalidOperationException("Silinmek istenen oyuncu bulunamadı.");

            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }
    }
}