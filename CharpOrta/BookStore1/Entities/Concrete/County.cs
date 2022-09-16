using Core.Entities;

namespace Entities.Concrete
{
    public class County : IEntity
    {
        public int Id { get; set; }
        public string CountyName { get; set; }
        public int CityId { get; set; }
    }
}
