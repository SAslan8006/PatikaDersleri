using AutoMapper;
using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.ActorOperations.Commands.Update
{
    public class UpdateActorCommand
    {
        private readonly IMovieStoreDbContext _context;
        public UpdateActorModel Model;
        public int Id;

        public UpdateActorCommand(IMovieStoreDbContext context)
        {
            _context = context;            
        }

        public void Handle()
        {
            Actor actor = _context.Actors.SingleOrDefault(x=> x.Id == Id);
            if(actor is null)
                throw new InvalidOperationException("Oyuncu bulunamadı.");
            
            actor.Name = actor.Name == default ? actor.Name : Model.Name;
            actor.SurName = actor.SurName == default ? actor.SurName : Model.SurName;

            _context.Actors.Update(actor);
            _context.SaveChanges();
        }
    }

    public class UpdateActorModel
    {
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}