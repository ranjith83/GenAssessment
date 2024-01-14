using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPrimeNumbers
{
    public class PrimeNumberCalc
    {
        private readonly IPrimeTable primeTable;
        public PrimeNumberCalc(IPrimeTable oPrimeTable)
        {

            primeTable = oPrimeTable;
        }

        public void GeneratePrintPrimes()
        {
            try
            {
                Console.Write("Enter the number (N) to generate  multiplication numbers: ");
                int n = int.Parse(Console.ReadLine());

                if (ValidatePrimeNos(n))
                {
                    int[] primeNumbers = primeTable.GetPrimeNumbers(n);
                    primeTable.PrintMultiplicationTable(primeNumbers);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        public bool ValidatePrimeNos(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return false;
            }

            if (n >= 50)
            {
                Console.WriteLine("Please enter less than 50.");
                return false;
            }
         
            return true;
        }
    }
}
