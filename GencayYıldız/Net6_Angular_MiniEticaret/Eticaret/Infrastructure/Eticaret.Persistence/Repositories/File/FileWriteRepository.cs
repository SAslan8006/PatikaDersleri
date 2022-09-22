using ETicaret.Application.Repositories;
using ETicaret.Persistence.Contexts;

namespace ETicaret.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<ETicaret.Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
