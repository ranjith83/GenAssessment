// See https://aka.ms/new-console-template for more information
using GenPrimeNumbers;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
            .AddSingleton<IPrimeTable, PrimeTable>()
            .BuildServiceProvider();



Console.WriteLine("Welcome to Prime Number Generation App!");
PrimeNumberCalc primeTable = new PrimeNumberCalc(serviceProvider.GetRequiredService<IPrimeTable>());
primeTable.GeneratePrintPrimes();