using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandCategoryDal : IBrandCategoryDal
    {

        public void Add(BrandCategory entity)
        {
            // IDispossable pattern implementation of c# 
            using (CarDbContext context = new CarDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }


        public void Delete(BrandCategory entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }


        public BrandCategory Get(Expression<Func<BrandCategory, bool>> filter)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.Set<BrandCategory>().SingleOrDefault(filter);
            }

        }

       
        public List<BrandCategory> GetAll(Expression<Func<BrandCategory, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return filter == null
                    ? context.Set<BrandCategory>().ToList()
                    : context.Set<BrandCategory>().Where(filter).ToList();
            }
        }

     

        public void Update(BrandCategory entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
