using System;
using System.Collections.Generic;
using System.Text;

namespace SobrePosicaoVirtualOverrideBase.Entities
{
    internal class SavingsAccount : Account//heranca
    {
        public double InterestRate { get; set; }//taxa de juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //sobrescrever a operação de saque, mas funcionando diferente pra essa subclasse:
        public override void Withdraw(double amount)
        {
            //chamei o metodo da superclasse(base) e descontei mais 2 reais do saldo final.
            base.Withdraw(amount);
            Balance -= 2.00;
        }
    }
}
/*SOBREPOSIÇÃO
reimplemento na sublclasse uma operação da superclasse, mas posso fazer alterações*/
