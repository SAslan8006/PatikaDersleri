using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLaungageDal : EfEntityRepositoryBase<Laungage, BookDbContext>, ILaungageDal
    {

    }
}
