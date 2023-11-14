using Microsoft.VisualStudio.TestPlatform.TestHost;
using RefresherExercise;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100.0, 6, 3, 80.0)]  // 20% alennus
        [InlineData(200.0, 6, 1, 180.0)] // 10% alennus
        [InlineData(50.0, 3, 6, 42.5)]   // 15% alennus
        [InlineData(150.0, 4, 4, 150.0)] // Ei alennusta
        public void CalculateDiscount_ReturnsExpectedResult(double price, int itemCount, int itemAge, double expected)
        {

            // Act
            double result = Assigments.CalculateDiscount(price, itemCount, itemAge);

            // Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 5)]
        [InlineData(new int[] { 10, 7, 5, 8, 11, 9 }, 6)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 0)]
        public void MaxProfit_ReturnsExpectedProfit(int[] prices, int expectedProfit)
        {
            // Act
            int profit = Assigments.MaxProfit(prices);

            // Assert
            Assert.Equal(expectedProfit, profit);
        }
    }
}