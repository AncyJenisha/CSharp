using CollectionAndGenerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndGenericsTests
{
    public class SumCalculatorTests
    {
        [Fact]
        public void ValidListGiven_SumOfElementsOfCalculation_Sum()
        {
            int[] listOfNumbers = { 1, 2, 3, 4, 5 };
            int checkSum = SumCalculator.SumOfElementsofCollection(listOfNumbers);
            Assert.True(checkSum == 15);
        }

        [Fact]
        public void ValidArrayGiven_SumOfElementsOfCalculation_Sum()
        {
            int[] arrayOfNumbers = { 1, 2, 3, 4, 5 };
            int checkSum = SumCalculator.SumOfElementsofCollection(arrayOfNumbers);
            Assert.True(checkSum == 15);
        }

        [Fact]
        public void ValidStackGiven_SumOfElementsOfCalculation_Sum()
        {
            Stack<int> stackOfNumbers = new();
            stackOfNumbers.Push(1);
            stackOfNumbers.Push(2);
            stackOfNumbers.Push(3);
            stackOfNumbers.Push(4);
            stackOfNumbers.Push(5);
            stackOfNumbers.Push(6);
            int checkSum = SumCalculator.SumOfElementsofCollection(stackOfNumbers);
            Assert.True(checkSum == 21);
        }

        [Fact]
        public void ValidQueueGiven_SumOfElementsOfCalculation_Sum()
        {
            Queue<int> queueOfNumbers = new();
            queueOfNumbers.Enqueue(1);
            queueOfNumbers.Enqueue(2);
            queueOfNumbers.Enqueue(3);
            queueOfNumbers.Enqueue(4);
            queueOfNumbers.Enqueue(5);
            queueOfNumbers.Enqueue(6);
            int checkSum = SumCalculator.SumOfElementsofCollection(queueOfNumbers);
            Assert.True(checkSum == 21);
        }
    }
}
