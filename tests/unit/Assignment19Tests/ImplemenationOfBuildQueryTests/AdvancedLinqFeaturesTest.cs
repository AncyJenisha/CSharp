namespace ImplemenationOfBuildQueryTests
{
    using AdvancedLinq;
    public class AdvancedLinqFeaturesTest
    {
        [Fact]
        public void WhenCalled_ImplementBuildQuery_JoinsList()
        {
            List<Supplier> suppliersList = SupplierManager.SuppliersList;
            List<Product> productsList = ProductsManager.ProductsList;
            BuildQueryImplementor buildQueryImplementor = new BuildQueryImplementor();

            var expectedResult = productsList
                .Where(p => p.ProductPrice > 100)
                .OrderBy(p => p.ProductPrice)
                .Join(
                suppliersList,
                product => product.ProductId,
                supplier => supplier.ProductId,
                (product, supplier) => (product, supplier));

            var actualResult = buildQueryImplementor.ImplementBuildQuery();

            Assert.Equal(expectedResult, actualResult);

        }
    }
}