using Business.Abstract;
using Business.Concrete.Manager;
using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.DataAccess.NHihabernate;
using DataAcsess.Absract;
using DataAcsess.Concrete.EntityFramework;
using DataAcsess.Concrete.NHibernate.Helpers;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
    public class BusnisessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
          

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>)); //NB geçersek burayı değişecek
            Bind<DbContext>().To<NortwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
