using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XistoreStore.Models;
using Xunit;

namespace XistoreStore.Tests
{
    public class CartTests
    {
        [Fact]
        public void Can_Add_New_Lines()
        {
            Product p1 = new Product { ProductID = 1, Name = "Xistore1" };
            Product p2 = new Product { ProductID = 2, Name = "Xistore2" };

            Cart target = new Cart();
            
            //Action
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            CartLine[] results = target.Lines.ToArray();

            //Assert
            Assert.Equal(2, results.Length);
            Assert.Equal(p1, results[0].Product);
            Assert.Equal(p2, results[1].Product);
                       
        }

        public void Can_Add_Quantity_For_Existing_Lines()
        {
            Product p1 = new Product { ProductID = 1, Name = "Xistore1" };
            Product p2 = new Product { ProductID = 2, Name = "Xistore2" };

            Cart target = new Cart();

            //Action
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p1, 10);
            CartLine[] results = target.Lines
                .OrderBy(c=>c.Product.ProductID).ToArray();

            //Assert
            Assert.Equal(2, results.Length);
            Assert.Equal(p1, results[0].Product);
            Assert.Equal(p2, results[1].Product);

        }


        public void Can_Remove_Line()
        {
            Product p1 = new Product { ProductID = 1, Name = "Xistore1" };
            Product p2 = new Product { ProductID = 2, Name = "Xistore2" };
            Product p3 = new Product { ProductID = 3, Name = "Xistore3" };

            Cart target = new Cart();

            //Action
            target.AddItem(p1, 1);
            target.AddItem(p2, 3);
            target.AddItem(p3, 5);
            target.AddItem(p2, 1);

            target.RemoveLine(p2);

            //Assert
            Assert.Equal(0, target.Lines.Where(c=>c.Product==p2).Count());
            Assert.Equal(2, target.Lines.Count());
        }

        public void Calculate_Cart_Total()
        {
            Product p1 = new Product { ProductID = 1, Name = "Xistore1", Price = 100 };
            Product p2 = new Product { ProductID = 2, Name = "Xistore2", Price = 50 };
            Product p3 = new Product { ProductID = 3, Name = "Xistore3", Price = 40 };

            Cart target = new Cart();

            //Action
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            target.AddItem(p3, 1);
            decimal result = target.ComputeTotalValue();
                   
            //Assert
            Assert.Equal(190, result);
        }

        public void Can_Clear_Contents()
        {
            Product p1 = new Product { ProductID = 1, Name = "Xistore1", Price = 100 };
            Product p2 = new Product { ProductID = 2, Name = "Xistore2", Price = 50 };
        
            Cart target = new Cart();
            target.AddItem(p1, 1);
            target.AddItem(p2, 1);
            
            
            //Action

            target.Clear();           

            //Assert
            Assert.Equal(0, target.Lines.Count());
        }


    }
}
