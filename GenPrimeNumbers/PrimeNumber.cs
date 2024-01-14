using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPrimeNumbers
{


    public class PrimeTable : IPrimeTable
    {

        public bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            if (num > 1000)
                return false;

            for (int i = 2; i * i <= (num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        public int[] GetPrimeNumbers(int n)
        {
            if(n < 0)
            return new int[0];

            int[] primes = new int[n];
            int count = 0;
            int i = 2;

            while (count < n)
            {
                if (IsPrime(i))
                {
                    primes[count] = i;
                    count++;
                }
                i++;
            }

            return primes;
        }

        public void PrintMultiplicationTable(int[] primenums)
        {
            Console.WriteLine($"\nMultiplication Table of  {primenums.Length} Prime Numbers:\n");
            Console.Write("    ");

            foreach (var prime in primenums)
            {
                Console.Write($"{prime} ");
            }
            Console.WriteLine("\n  +---------------------------------------");

            foreach (var rowPrime in primenums)
            {
                Console.Write($"{rowPrime + " | "}");
                foreach (var colPrime in primenums)
                {
                    Console.Write($"{rowPrime * colPrime} ");
                }
                Console.WriteLine();
            }
        }


    }
}

