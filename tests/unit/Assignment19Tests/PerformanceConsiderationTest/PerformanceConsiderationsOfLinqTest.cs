namespace PerformanceConsiderationTest
{
    using AdvancedLinq;
    public class PerformanceConsiderationsOfLinqTest
    {
        [Fact]
        public void WhenCalled_FilterAndSortBooks_ReturnListOfSortedBooks()
        {
            ProductsManager productsManager = new ProductsManager();
            productsManager.IntializeWithDefaultProducts();

            PerformanceConsiderationsOfLinq performanceConsiderationsOfLinq = new PerformanceConsiderationsOfLinq();
            List<Product> actualListOfBooks = performanceConsiderationsOfLinq.FilterAndSortBooks();

            Assert.Equal(2,actualListOfBooks.Count);
        }
    }
}