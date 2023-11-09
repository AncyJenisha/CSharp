using AdvancedLanguageFeatres;
using System.Drawing;

namespace AdvancedPatternMatchingTests
{
    public class CalculateAreaTestClass
    {
        [Fact]
        public void ValidLengthAndBreadthGiven_GetArea_AreaReturned()
        {
            AdvancedLanguageFeatres.Rectangle rectangle = new(14.25F, 13.25F);

            float actualArea = rectangle.CalculateArea();

            Assert.Equal(188.8125, actualArea);
        }

        [Fact]
        public void ValidRadiusGiven_GetArea_AreaReturned()
        {
            AdvancedLanguageFeatres.Circle circle = new(13.16F);

            float actualArea = circle.CalculateArea();

            Assert.Equal(8.2644805908203125, actualArea);
        }

        [Fact]
        public void ValidLengthAndBreadthGiven_GetArea_AreReturned()
        {
            AdvancedLanguageFeatres.Triangle triangle = new(13.25F, 14.25F);

            float actualArea = triangle.CalculateArea();

            Assert.Equal(94.40625, actualArea);
        }
    }
}