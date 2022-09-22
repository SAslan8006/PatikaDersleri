using ETicaret.Application.Repositories;
using ETicaret.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repositories
{
    public class ProductImageFileReadRepository : ReadRepository<ETicaret.Domain.Entities.ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
