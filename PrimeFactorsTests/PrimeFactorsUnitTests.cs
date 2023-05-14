using PrimeFactorsLib;

namespace PrimeFactorsTests
{
    public class PrimeFactorsUnitTests
    {
        [Fact]
        public void TestPrimeFactorsOf4()
        {
            // Arrange
            int number = 4;
            string expected = "2 x 2";

            
            // Act
            string actual = Primes.PrimeFactors(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorsOf30()
        {
            // Arrange
            int number = 30;
            string expected = "5 x 3 x 2";

            // Act
            string actual = Primes.PrimeFactors(number);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrimeFactorsOf7()
        {
            // Arrange
            int number = 7;
            string expected = "7";

            // Act
            string actual = Primes.PrimeFactors(number);

            // Assert
            Assert.Equal(expected, actual);
        }
        
        
    }
}