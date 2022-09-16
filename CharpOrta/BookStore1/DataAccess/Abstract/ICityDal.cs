using Core.DataAccess;
using Entities.Concrete;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICityDal : IEntityRepository<City>
    {
    }
}
