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
    public class BasketReadRepository : ReadRepository<Basket>, IBasketReadRepository
    {
        public BasketReadRepository(ETicaretDBContext context) : base(context)
        {
        }
    }
}
