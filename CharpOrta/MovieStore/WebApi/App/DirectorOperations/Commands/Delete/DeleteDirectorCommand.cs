using WebApi.DbOperations;
using WebApi.Entites;

namespace WebApi.App.DirectorOperations.Commands.Delete
{
    public class DeleteDirectorCommand
    {
        private readonly IMovieStoreDbContext _dbContext;

        public int Id { get; set; }

        public DeleteDirectorCommand(IMovieStoreDbContext context)
        {
            _dbContext = context;

        }
        public void Handle()
        {
            Director director = _dbContext.Directors.SingleOrDefault(s => s.Id == Id);
            if (director is null)
                throw new InvalidOperationException("Yönetmen bulunamadı.");

            _dbContext.Directors.Remove(director);
            _dbContext.SaveChanges();
        }
    }
}