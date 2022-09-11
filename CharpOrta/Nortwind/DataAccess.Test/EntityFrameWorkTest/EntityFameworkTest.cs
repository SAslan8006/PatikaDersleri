using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataAccess.Test.EntityFrameWorkTest
{
    [TestClass]
    public class EntityFameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();
            var result = productDal.GetList();
            Assert.AreEqual(85, result.Count);

        }
    }
}
