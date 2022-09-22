using ETicaret.Application.Repositories;
using ETicaret.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<ETicaret.Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
