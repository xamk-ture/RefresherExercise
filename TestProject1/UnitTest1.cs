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

          [Theory]
  [InlineData("III", 3)]
  [InlineData("IV", 4)]
  [InlineData("XIV", 14)]
  [InlineData("IX", 9)]
  [InlineData("LVIII", 58)]
  [InlineData("MCMXCIV", 1994)]
  public void ConvertToArabic_ValidRomanNumerals_ReturnsCorrectArabicNumber(string roman, int expected)
  {
      int result = Assigments.RomanToInt(roman);
      Assert.Equal(expected, result);
  }

  [Theory]
  [InlineData(1, "I")]
  [InlineData(3, "III")]
  [InlineData(4, "IV")]
  [InlineData(9, "IX")]
  [InlineData(58, "LVIII")]
  [InlineData(1994, "MCMXCIV")]
  public void ConvertToRoman_ValidNumbers_ReturnsCorrectRomanNumeral(int number, string expected)
  {
      string result = Assigments.IntToRoman(number);
      Assert.Equal(expected, result);
  }

  [Theory]
  [InlineData(0)]
  [InlineData(4000)]
  public void ConvertToRoman_InvalidNumbers_ThrowsArgumentException(int number)
  {
      Assert.Throws<ArgumentOutOfRangeException>(() => Assigments.IntToRoman(number));
  }
    }
}
