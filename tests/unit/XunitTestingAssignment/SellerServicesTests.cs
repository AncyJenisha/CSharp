namespace XunitTestingAssignment
{
    /// <summary>
    /// SellerServicesTests has test methods to check the service methods of the seller.
    /// </summary>
    public class SellerServicesTests
    {
        [Fact]
        public void AddProducts_ProductDetailsCorrectlyGiven_UpdatesList()
        {
            Console.SetIn(new StringReader("productname\n25\n25.02\n"));
            SellerServices.AddProducts();
            Assert.True(SellerServices.ProductsforSaleList.Count == 1);
        }

        [Fact]
        public void AddProducts_InvalidProductDetailsGiven_AsksforValidInputAndUpdatesList()
        {
            Console.SetIn(new StringReader("productname\nFis#$\n25\n25.02\n"));
            SellerServices.AddProducts();
            Assert.True(SellerServices.ProductsforSaleList.Count == 1);
        }

        [Fact]
        public void DeleteProducts_ValidIndexGiven_RemovesObjectFromList()
        {
            Console.SetIn(new StringReader("Pname\n67\n23.02\n"));
            SellerServices.AddProducts();
            Console.SetIn(new StringReader("1\n"));
            SellerServices.DeleteProducts();
            Assert.Empty(SellerServices.ProductsforSaleList);
        }

        [Fact]
        public void DeleteProducts_InValidIndexGiven_ShouldNotRemoveObjectFromList()
        {
            Console.SetIn(new StringReader("Pname\n67\n23.02\n"));
            SellerServices.AddProducts();
            Console.SetIn(new StringReader("3\n"));
            SellerServices.DeleteProducts();
            Assert.NotEmpty(SellerServices.ProductsforSaleList);
        }
    }
}
