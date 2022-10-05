using Northwind.DataAccess.Absract;
using Northwind.Entities.Absract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContex> : IEntityRepository<TEntity>
        where TEntity : class,IEntity,new()
        where TContex : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContex context = new TContex())
            {
               var addEntity=context.Entry(entity);
                addEntity.State=EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContex context = new TContex())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex context = new TContex())
            {
                return filter==null?context.Set<TEntity>().ToList():
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContex context = new TContex())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
