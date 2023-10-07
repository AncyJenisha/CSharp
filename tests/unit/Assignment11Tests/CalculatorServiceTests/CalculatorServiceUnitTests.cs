using CalculationService;

namespace XunitTestingAssignment
{
    public class CalculatorServiceUnitTests
    {
        [Theory]
        [InlineData(10, 3, 13)]
        [InlineData(0, 0.23, 0.23)]
        [InlineData(10.25, 3.00, 13.25)]
        public void Addition_BothInputsArePositive_GivesPositiveNumberAsResult(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = Calculator.Addition(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);

        }

        [Theory]
        [InlineData(Double.MaxValue, Double.MaxValue, Double.PositiveInfinity)]
        public void Addition_BothInputsAreMaximumValue_GivesPositiveInfiniteNumberAsResult(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = Calculator.Addition(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(2, -5, 7)]
        [InlineData(2, -0.15, 2.15)]
        public void Subtraction_FirstNumberLargerThanSecondNumber_GivesPositiveNumberAsResult(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = Calculator.Subtraction(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(2, 10, -8)]
        [InlineData(20, -5.10, 25.10)]
        public void Subtraction_SecondNumberLargerThanFirstNumber_GivesNegativeNumberAsNumber(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = Calculator.Subtraction(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-2, -10, 8)]
        [InlineData(-20, -10, -10)]
        public void Subtraction_BothInputsAreNegativeNumbers_GivesPositiveNumberAsNumber(double x, double y, double expectedresult)
        {
            double actualResult = Calculator.Subtraction(x, y);
            Assert.Equal(expectedresult, actualResult);
        }

        [Theory]
        [InlineData(3, 3, 9)]
        [InlineData(3, 100, 300)]
        public void Multiplication_BothMultiplicantAndMultiplierArePositiveNumbers_GivesPositiveNumberAsResult(double firstNumber, double secondNumber, double expectedresult)
        {
            double actualResult = Calculator.Multiplication(firstNumber, secondNumber);
            Assert.Equal(expectedresult, actualResult);
        }

        [Theory]
        [InlineData(3, -3, -9)]
        [InlineData(-3, -3, 9)]
        public void Multiplication_OneOfTheInputIsANegativeNumber_GivesPositiveNumberAsResult(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = Calculator.Multiplication(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, 0, 0)]
        [InlineData(0, 3, 0)]
        public void Multiplication_OneOfTheInputIsZero_GivesZeroAsResult(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualResult = Calculator.Multiplication(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(5, 1, 5)]
        [InlineData(15, 3, 5)]
        public void Division_DivisorandDividentArePositive_QuotientIsPositive(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualValue = Calculator.Division(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualValue);
        }

        [Theory]
        [InlineData(15, -3, -5)]
        [InlineData(-15, 3, -5)]
        public void Division_DivisororDividentIsNegative_QuotientIsNegative(double x, double y, double expectedresult)
        {
            double actualvalue = Calculator.Division(x, y);
            Assert.Equal(expectedresult, actualvalue);
        }

        [Theory]
        [InlineData(17, 3.16, 5.379746835443037)]
        [InlineData(16.23, 13.03, 1.2455871066768995)]
        [InlineData(-13.16, 7.10, -1.8535211267605636)]
        public void Division_DivisororDividentIsFraction_QuotientIsFraction(double firstNumber, double secondNumber, double expectedResult)
        {
            double actualValue = Calculator.Division(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualValue);
        }
    }
}