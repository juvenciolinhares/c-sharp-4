
using ExercicioPropExcecoes.Entities.Exceptions;
using System.Globalization;

namespace ExercicioPropExcecoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double Withdraw { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdraw)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            Withdraw = withdraw;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw(double amount)
        {

            if (amount > Withdraw)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }
            if (amount > Balance )
            {
                throw new DomainExceptions("Not enough balance");
            }
            
            Balance -= amount;
            
        }

    }
}
/*
 * não pode ocorrer saque se:
 * não houver saldo na conta
 * valor do saque maior ao limite de saque da conta
 * 
 */
