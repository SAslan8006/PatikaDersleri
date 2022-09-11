using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Business.Test
{
    [TestClass]
    public class ProductManagerTests
    {
        [TestMethod]
        public void Product_validation_check()
        {
            Mock < IProductDal >= new Mock<IProductDal>();
            ProductManager = new ProductManager(mock.Object);
        }
    }
}
