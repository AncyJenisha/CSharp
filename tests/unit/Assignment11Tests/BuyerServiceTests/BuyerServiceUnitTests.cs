using CalculationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitTestingAssignment
{
    public class BuyerServicesTests
    {
        [Fact]
        public void AddProductstoCart_ValidProductIdandQuantityGiven_UpdatesOrderedProductsList()
        {
            Console.SetIn(new StringReader("pname1\n30\n25.02\n"));
            SellerServices.AddProducts();
            Console.SetIn(new StringReader("pname2\n25\n25.02\n"));
            SellerServices.AddProducts();
            Console.SetIn(new StringReader("2\n15"));
            BuyerServices.AddProductstocart();
            Assert.True(BuyerServices.OrderedProductsList.Count == 1);
        }

        [Fact]
        public void RemoveFromCart_ValidProductIdGiven_RemovesOrderedProductsList()
        {
            Console.SetIn(new StringReader("pname1\n30\n25.02\n"));
            SellerServices.AddProducts();
            Console.SetIn(new StringReader("1\n15"));
            BuyerServices.AddProductstocart();
            Console.SetIn(new StringReader("1\n"));
            BuyerServices.RemoveFromCart();
            Assert.Single(BuyerServices.OrderedProductsList);
        }

        [Fact]
        public void RemoveFromCart_InvalidValidProductIdGiven_OrderedProductsListRemainsSame()
        {
            Console.SetIn(new StringReader("pname1\n30\n25.02\n"));
            SellerServices.AddProducts();
            Console.SetIn(new StringReader("1\n15"));
            BuyerServices.AddProductstocart();
            Console.SetIn(new StringReader("5\n"));
            BuyerServices.RemoveFromCart();
            Assert.NotEmpty(BuyerServices.OrderedProductsList);
        }
    }
}