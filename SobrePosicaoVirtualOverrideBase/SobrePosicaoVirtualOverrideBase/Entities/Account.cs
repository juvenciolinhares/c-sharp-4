using System;
using System.Collections.Generic;
using System.Text;

namespace SobrePosicaoVirtualOverrideBase.Entities
{
    internal class Account
    {

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }//o protected permite acesso ao saldo pela subclasse

        public Account()
        {
        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //palavra virtual: permite sobrepor esse método nas subclasses
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.00;//taxa de saque
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
/*SOBREPOSIÇÃO
reimplemento na sublclasse uma operação da superclasse, mas posso fazer alterações*/