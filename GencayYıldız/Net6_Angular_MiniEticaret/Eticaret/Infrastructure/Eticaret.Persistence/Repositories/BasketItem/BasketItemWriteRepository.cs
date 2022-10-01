using ETicaret.Application.Repositories;
using ETicaret.Domain.Entities;
using ETicaret.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Repositories
{
    public class BasketItemWriteRepository : WriteRepository<BasketItem>, IBasketItemWriteRepository
    {
        public BasketItemWriteRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
