using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using XistoreStore.Contollers;
using XistoreStore.Models;
using XistoreStore.Models.ViewModels;
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
            ProductListViewModel result = controller.List(null,2).ViewData.Model as ProductListViewModel;

            //Assert
            Product[] prodArray = result.Products.ToArray();
            Assert.True(prodArray.Length == 2);
            Assert.Equal("Xistore4", prodArray[0].Name);
            Assert.Equal("Xistore5", prodArray[1].Name);

        }
        [Fact]
        public void Can_Sent_Pagination_View_Model()
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
           ProductListViewModel result = controller.List(null,2).ViewData.Model as ProductListViewModel;

            //Assert
            PagingInfo pageInfo = result.PagingInfo;
            Assert.Equal(2, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(5,pageInfo.TotalItems);
            Assert.Equal(2,pageInfo.TotalPages);

        }

        public void Can_Filter_Products()
        {
            //Arrange
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[] {
                new Product { ProductID=1,Name="Xistore1",Category="Cat1"},
                new Product { ProductID=2,Name="Xistore2",Category="Cat2"},
                new Product { ProductID=3,Name="Xistore3",Category="Cat1"},
                new Product { ProductID=4,Name="Xistore4",Category="Cat2"},
                new Product { ProductID=5,Name="Xistore5",Category="Cat3"}
            }).AsQueryable<Product>());

            ProductController controller = new ProductController(mock.Object);
            controller._pageSize = 3;

            //Action
            Product[] result = (controller.List("Cat2", 2).ViewData.Model as ProductListViewModel)
            .Products.ToArray();

            //Assert
            Assert.Equal(2, result.Length);
            Assert.True(result[0].Name == "Xistore2" && result[0].Category == "Cat2");
            Assert.True(result[1].Name == "Xistore4" && result[1].Category == "Cat2");
          

    }
    }
}
