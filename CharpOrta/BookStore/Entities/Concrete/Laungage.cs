using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Laungage : IEntity
    {
        public int Id { get; set; }
        public string BookLaungage { get; set; }
    }
}
