using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Adres { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        public string PostCode { get; set; }
        public int BookId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
