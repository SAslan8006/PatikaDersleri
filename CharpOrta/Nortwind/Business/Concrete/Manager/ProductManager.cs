using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Postsharp.CacheAspects;
using Core.Aspect.Postsharp.LogAspects;
using Core.Aspect.Postsharp.PeroformanceAspects;
using Core.Aspect.Postsharp.TransactionAspects;
using Core.Aspect.Postsharp.ValidationAspects;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using DataAcsess.Absract;
using Entities.Concrete;
using Org.BouncyCastle.Asn1.X509;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Concrete.Manager
{
    //[LogAspect(typeof(DatabaseLogger))] tüm class ı loglar
   //[LogAspect(typeof(FileLogger))]
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [SecuredOperation(Roles="Admin,Editor")]
        [FluentValidationAspect(typeof(ProductValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        [PerformanceCounterAspect]
        [CacheAspect(typeof(MemoryCacheManager),60)]
        [LogAspect(typeof(DatabaseLogger))]
        [LogAspect(typeof(FileLogger))]
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        [PerformanceCounterAspect]
        [TransactionScopeAspect]
        public void TransactionalOperation(Product product, Product product1)
        {
            _productDal.Add(product);
            //Business Codes
            _productDal.Update(product1);
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Product Update(Product product)
        {            
            return _productDal.Update(product);
        }
    }
}
