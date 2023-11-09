using SortUsingDelegates;
namespace SortUsingDelegatesTests
{
    public class ProductSorterTests
    {
        [Fact]
        public void TwoProductNamesGivenInAlphabeticalOrder_SortByName_CountChanges()
        {
            Product firstProduct = new()
            {
                ProductName = "Hide and Seek",
                Category = "Biscuit",
                Price = 30
            };
            Product secondProduct = new()
            {
                ProductName = "Milk Bikis",
                Category = "Biscuit",
                Price = 15
            };

            int actualValue = ProductsSorters.SortByName(firstProduct, secondProduct);

            Assert.Equal(-1, actualValue);
        }

        [Fact]
        public void TwoProductNamesNotGivenInAlphabeticalOrder_SortByName_CountChanges()
        {
            Product firstProduct = new()
            {
                ProductName = "Milk Bikis",
                Category = "Biscuit",
                Price = 15
            };
            Product secondProduct = new()
            {
                ProductName = "Hide and Seek",
                Category = "Biscuit",
                Price = 30
            };

            int actualValue = ProductsSorters.SortByName(firstProduct, secondProduct);

            Assert.Equal(1, actualValue);
        }

        [Fact]
        public void TwoProductCategoryGivenInAlphabetical_SortByCategory_ReturnsMinusOne()
        {
            Product firstProduct = new()
            {
                ProductName = "Milk Bikis",
                Category = "Biscuit",
                Price = 15
            };
            Product secondProduct = new()
            {
                ProductName = "KitKat",
                Category = "Chocolate",
                Price = 25
            };

            int actualValue = ProductsSorters.SortByCategory(firstProduct, secondProduct);

            Assert.Equal(-1, actualValue);
        }

        [Fact]
        public void TwoProductCategoryNotGivenInAlphabetical_SortByCategory_ReturnsOne()
        {
            Product firstProduct = new()
            {
                ProductName = "Surf Excel",
                Category = "Detergent",
                Price = 50
            };
            Product secondProduct = new()
            {
                ProductName = "KitKat",
                Category = "Chocolate",
                Price = 25
            };

            int actualValue = ProductsSorters.SortByCategory(firstProduct, secondProduct);

            Assert.Equal(1, actualValue);
        }

        [Fact]
        public void TwoProductPriceGivenInAscendingOrder_SortByPrice_ReturnsMinusOne()
        {
            Product firstProduct = new()
            {
                ProductName = "Milk Bikis",
                Category = "Biscuit",
                Price = 15
            };
            Product secondProduct = new()
            {
                ProductName = "KitKat",
                Category = "Chocolate",
                Price = 25
            };

            int actualValue = ProductsSorters.SortByPrice(firstProduct, secondProduct);

            Assert.Equal(-1, actualValue);
        }

        [Fact]
        public void TwoProductPriceGivenInDescendingOrder_SortByPrice_ReturnsOne()
        {
            Product firstProduct = new()
            {
                ProductName = "Milk Bikis",
                Category = "Biscuit",
                Price = 15
            };
            Product secondProduct = new()
            {
                ProductName = "KitKat",
                Category = "Chocolate",
                Price = 5
            };

            int actualValue = ProductsSorters.SortByPrice(firstProduct, secondProduct);

            Assert.Equal(1, actualValue);
        }

    }
}