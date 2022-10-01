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
    public class BasketItemReadRepository : ReadRepository<BasketItem>, IBasketItemReadRepository
    {
        public BasketItemReadRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
