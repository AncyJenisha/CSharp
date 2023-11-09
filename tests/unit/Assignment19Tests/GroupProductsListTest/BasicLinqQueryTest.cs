using AdvancedLinq;

namespace GroupProductsListTest
{
    public class BasicLinqQueriesTest
    {
        [Fact]
        public void WhenCalled_GroupProductsBasedOnCategory_ReturnsGroupedList()
        {
            List<Product> productsList = ProductsManager.Products;
            var expectedGroupedProductList = from product in productsList.OrderByDescending((product) => product.ProductPrice)
                                     group product by product.ProductCategory into categoryGroup
                                     select categoryGroup;

            BasicLinqQueries basicLinqQueries = new BasicLinqQueries();
            var actualGroupedProductList = basicLinqQueries.GroupProductsBasedOnCategory();
            Assert.Equal(expectedGroupedProductList, actualGroupedProductList);
            
        }
    }
}