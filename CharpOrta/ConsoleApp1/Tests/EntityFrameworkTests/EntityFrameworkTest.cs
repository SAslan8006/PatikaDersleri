using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System;

namespace Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
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
