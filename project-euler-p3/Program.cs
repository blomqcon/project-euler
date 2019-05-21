using System;
using System.Collections.Generic;
using System.Linq;

namespace project_euler_p3
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 600_851_475_143;
            var primeFactors = new List<long>();

            long prime = 2;
            do {
                if (number % prime == 0)
                {
                    number = number / prime;
                    primeFactors.Add(prime);
                }
                else
                {
                    prime = NextPrime(prime);
                }

            } while (prime <= number);

            
            Console.WriteLine($"Answer: {primeFactors.Last()}");
        }

        private static long NextPrime(long prime)
        {
            for (var candidate = prime + 1; true; candidate++)
            {
                long i;
                for (i = 2; i < candidate; i++)
                {
                    if (candidate % i == 0)
                        break;
                }

                if (i == candidate)
                {
                    return candidate;
                }
            }
        }
    }
}
