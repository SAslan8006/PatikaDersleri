using Core.Entities;

namespace Entities.Concrete
{
    public class Cargo : IEntity
    {
        public int Id { get; set; }
        public string CargoName { get; set; }
    }
}
