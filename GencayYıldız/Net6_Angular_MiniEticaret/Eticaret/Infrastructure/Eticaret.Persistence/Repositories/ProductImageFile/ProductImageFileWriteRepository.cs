using ETicaret.Application.Repositories;
using ETicaret.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repositories
{
    public class ProductImageFileWriteRepository : WriteRepository<ETicaret.Domain.Entities.ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
