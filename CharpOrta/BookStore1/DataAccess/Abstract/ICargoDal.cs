using Core.DataAccess;
using Entities.Concrete;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICargoDal : IEntityRepository<Cargo>
    {
    }
}
