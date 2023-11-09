namespace GenerateUniquePairsTest
{
    using AdvancedLinq;

    public class BasicLinqQueriesTest
    {
        [Fact]
        public void ValidTargetValueGiven_GerateUniquePairsThatAddUpToTarget_GivesNumberPairs()
        {
            ProductsManager productsManager = new ProductsManager();
            productsManager.IntializeWithDefaultProducts();
            LinqToObjects linqToObjects = new LinqToObjects();

            Console.SetIn(new StringReader("29"));
            List<(int, int)> actualNumberPairs = linqToObjects.GenerateUniquePairsThatAddUpToTarget();
            List<(int, int)> expectedNumberPairs = new() { (23, 6),(16,13) };
            Assert.Equal(expectedNumberPairs, actualNumberPairs);
        }
    }
}