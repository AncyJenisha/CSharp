
namespace AdvancedLinqTest
{
    using AdvancedLinq;

    public class FilterProductsTest
    {

        [Fact]
        public void WhenCalled_FilterProducts_FiltersProductsByCategory()
        {
            ProductsManager productsManager = new ProductsManager();
            productsManager.IntializeWithDefaultProducts();

            BasicLinqQueries basicLinqQueries = new BasicLinqQueries();
            List<Tuple<string, float>> ListOfFilteredProduts = basicLinqQueries.FilterProducts();
            List<Tuple<string, float>> expectedListOfProducts =new () { Tuple.Create("Laptop", 600F) };

            Assert.Equal(expectedListOfProducts, ListOfFilteredProduts);
        }
    }
}