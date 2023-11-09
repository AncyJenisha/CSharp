namespace ImplementationOfJoin
{
    using AdvancedLinq;
    public class BasicLinqQueriesTest
    {
        [Fact]
        public void WhenCalled_JoinProductAndSupplierList_ReturnsJoinedList()
        {
            List<Product> productsList = ProductsManager.Products;
            List<Supplier> suppliersList = SupplierManager.Suppliers;
            BasicLinqQueries basicLinqQueries = new BasicLinqQueries();

            var expectedJoinedList = productsList.Join(
                suppliersList,
                product => product.ProductId,
                supplier => supplier.ProductId,
                (product, supplier) => Tuple.Create(
                    product.ProductId,
                    product.ProductName,
                    product.ProductPrice,
                    product.ProductCategory,
                    supplier.SupplierId,
                    supplier.SupplierName)).ToList();
            var actualJoinedList = basicLinqQueries.JoinProductAndSupplierList();

            Assert.Equal(expectedJoinedList, actualJoinedList);
        }
    }
}