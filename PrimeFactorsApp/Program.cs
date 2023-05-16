// PrimeFactorsApp

using PrimeFactorsLib;

string result = Primes.PrimeFactors(8);
WriteLine($"The prime factors of 8 are {result}");

List<int> resultList = Primes.PrimeFactorsList(8);
WriteLine($"List contains {resultList.Count} items");
int counter = 1;
foreach( int i in resultList )
{
   if (counter < resultList.Count)
    {
        Write($"{i} x ");
    }
   else
    {
        Write(i);
    }
   counter++;
}

