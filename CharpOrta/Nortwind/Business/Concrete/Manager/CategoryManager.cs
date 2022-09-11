using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Postsharp.CacheAspects;
using Core.Aspect.Postsharp.LogAspects;
using Core.Aspect.Postsharp.TransactionAspects;
using Core.Aspect.Postsharp.ValidationAspects;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using DataAcsess.Absract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Concrete.Manager
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        
        [FluentValidationAspect(typeof(CategoryValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Category Add(Category category)
        {
            return _categoryDal.Add(category);
        }

        [CacheAspect(typeof(MemoryCacheManager),60)]
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(p => p.CategoryId == id);
        }
        [TransactionScopeAspect]
        public void TransactionalOperation(Category category, Category category1)
        {
            _categoryDal.Add(category);
            //Business Codes
            _categoryDal.Update(category1);
        }

        [FluentValidationAspect(typeof(CategoryValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Category Update(Category category)
        {            
            return _categoryDal.Update(category);
        }
    }
}
