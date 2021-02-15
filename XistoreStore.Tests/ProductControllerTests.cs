using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using XistoreStore.Contollers;
using XistoreStore.Models;
using Xunit;

namespace XistoreStore.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product { ProductID=1,Name="Xistore1"},
                new Product { ProductID=2,Name="Xistore2"},
                new Product { ProductID=3,Name="Xistore3"},
                new Product { ProductID=4,Name="Xistore4"},
                new Product { ProductID=5,Name="Xistore5"}
            }).AsQueryable<Product>());

            ProductController controller = new ProductController(mock.Object);
            controller._pageSize = 3;

            //Action
            IEnumerable<Product> result = controller.List(2).ViewData.Model as IEnumerable<Product>;

            //Assert
            Product[] prodArray = result.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("Xistore4", prodArray[0].Name);
            Assert.Equal("Xistore5", prodArray[1].Name);

        }
    }
}
