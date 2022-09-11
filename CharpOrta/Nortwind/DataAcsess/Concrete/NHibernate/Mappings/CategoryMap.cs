using Entities.Concrete;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel.ClassBased;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsess.Concrete.NHibernate.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Table(@"Categories");
            LazyLoad();
            Id(x => x.CategoryId).Column("CategoryId");

            Map(x => x.CategoryId).Column("CategoryId");
            Map(x => x.CategoryName).Column("CategoryName");


        }
    }
}
