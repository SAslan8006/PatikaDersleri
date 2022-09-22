using F= ETicaret.Domain.Entities; //Tür bildirim için kullanılır
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Repositories
{
    public interface IFileWriteRepository : IWriteRepository<F::File>
    {
    }

}
