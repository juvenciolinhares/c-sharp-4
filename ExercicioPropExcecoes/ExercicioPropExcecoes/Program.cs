using System;
using System.Globalization;
using ExercicioPropExcecoes.Entities;
using ExercicioPropExcecoes.Entities.Exceptions;

namespace ExercicioPropExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account conta = new Account(number, holder, balance, withdraw);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);
                conta.withdraw(amount);

                Console.WriteLine("New balance: " + conta.Balance);
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }

        }
    }
}
