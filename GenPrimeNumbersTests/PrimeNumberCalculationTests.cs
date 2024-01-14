using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenPrimeNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace GenPrimeNumbers.Tests
{
    [TestClass()]
    public class PrimeNumberCalculationTests
    {
        private readonly PrimeNumberCalc primeNumberCalculation;
        public PrimeNumberCalculationTests() {

            //Implement DI
            var serviceProvider = new ServiceCollection()
          .AddTransient<IPrimeTable, PrimeTable>()
          .BuildServiceProvider();

            var primeTable = serviceProvider.GetService<IPrimeTable>();

            //Act
            primeNumberCalculation = new PrimeNumberCalc(primeTable);
            var primeNumber = primeNumberCalculation.ValidatePrimeNos(100);
        }
        
        [TestMethod()]
        public void PrimeNumber_PostiveCase()
        {
            //Arrange
            PrimeTable primeTable1 = new();


            //Act
            var isPrime = primeTable1.IsPrime(31);

            //Assert
            Assert.IsTrue(isPrime);
        }

        [TestMethod()]
        public void PrimeNumber_NegativeCase()
        {
            //Arrange
            PrimeTable primeTable1 = new();


            //Act
            var isPrime = primeTable1.IsPrime(25);

            //Assert
            Assert.IsFalse(isPrime);
        }

        [TestMethod()]
        public void GeneratePrimeNumer_Postive()
        {
            //Arrange
            PrimeTable primeTable = new();
            //int[] 

            //Act
            var primeNumber = primeTable.GetPrimeNumbers(5);
            
            //Assert
            Assert.IsTrue(primeNumber.Length == 5);
        }

        [TestMethod()]
        public void GeneratePrimeNumer_Negative()
        {
            //Arrange
            PrimeTable primeTable = new();

            //Act
            var primeNumber = primeTable.GetPrimeNumbers(-1);

            //Assert
            Assert.IsTrue(primeNumber.Length == 0);
        }

        [TestMethod()]
        public void ValidatePrimeNumer_Positive()
        {
            //Arrange
            int primeNumber = 23;

            //Act
            var isValid = primeNumberCalculation.ValidatePrimeNos(primeNumber);

            //Assert
            Assert.IsTrue(isValid);
        }

        [TestMethod()]
        public void ValidatePrimeNumer_Negative()
        {
            //Arrange
            int primeNumber = 100;

            //Act
            var isValid = primeNumberCalculation.ValidatePrimeNos(primeNumber);

            //Assert
            Assert.IsFalse(isValid);
        }


    }
}