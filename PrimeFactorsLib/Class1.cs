namespace PrimeFactorsLib
{
    public class Primes
    {
        public static readonly int[] PrimeNumbers = new[]
        {
            19, 17, 13, 11,
            7, 5, 3, 2
        };

        public static string PrimeFactors(int number)
        {
            if ((number < 1) || (number > 1000)) // Test for initial validity
            {
                return $"{nameof(number)} must be between 1 and 1000";
            }

            string factors = string.Empty; // Initalize empty string this will be returned.

            foreach (int divisor in PrimeNumbers)
            {
                int remainder; // Initalize empty int to hold remainder
                do
                {
                    remainder = number % divisor; // Will be 0 if divisble by this prime
                    if (remainder == 0)
                    {
                        number /= divisor;
                        if (number == 1) // Signifies this is the last primte factor
                        {
                            factors += $"{divisor}";
                        }
                        else
                        {
                            factors += $"{divisor} x "; // More prime factors to come, prepare string accordingly
                        }
                    }

                } while (remainder == 0);
            }
            return factors;
        }
    }
}