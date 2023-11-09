namespace ImplementationOfLambdaExpressionToFilter
{
    using AdvancedLinq;
    public class AdvancedLinqFeaturesTest
    {
        [Fact]
        public void WhenCalled_FilterProductsUsingLambdaExpression_FiltersSnacksFromList()
        {
            List<Product> productsList = ProductsManager.Products;
            AdvancedLinqFeatures advancedLinqFeatures = new AdvancedLinqFeatures();

            IEnumerable<Product> listOfExpectedFilteredProducts = from product in productsList 
                                                           where product.ProductCategory == "Snacks"
                                                           select product;
            List<Product> listOfActualFilteredProducts = advancedLinqFeatures.FilterListOfProductsUsingLambdaExpression(product => product.ProductCategory == "Snacks");

            Assert.Equal(listOfExpectedFilteredProducts.ToList(), listOfActualFilteredProducts);

        }
    }
}