using MultithreadImplementation;

namespace MultiThreadImplementationTests
{
    public class MathOperatorsTests
    {
        [Fact]
        public void WhenCalled_CreateArray_ReturnsArray()
        {
            int[] expectedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actualArray = MathOperaters.CreateArray();
            Assert.Equal(expectedArray, actualArray);
        }

        [Fact]
        public void ValidArrayGiven_SquareArrayElements_ReturnsArrayOfSquaredElements()
        {
            int[] givenArray = new int[] { 2, 4, 3, 5, 13, 12, 1, 9, 10, 7 };
            int[] expectedArray = new int[] { 4, 16, 9, 25, 169, 144, 1, 81, 100, 49 };
            int[] actualArray = MathOperaters.SquareArrayElements(givenArray);
            Assert.Equal(expectedArray, actualArray);
        }

    }
}