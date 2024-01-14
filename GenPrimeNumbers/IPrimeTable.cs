using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPrimeNumbers
{
    public interface IPrimeTable
    {
        bool IsPrime(int num);

        void PrintMultiplicationTable(int[] primenums);

        int[] GetPrimeNumbers(int n);
        
    }
}
