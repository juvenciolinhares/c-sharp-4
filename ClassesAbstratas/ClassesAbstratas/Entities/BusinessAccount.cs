using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratas.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}
/*CLASSE ABSTRATA
 * classes que não podem ser instanciadas;
forma de garantir herança total. somente subclasses não abstratas podem ser instanciadas, mas nunca uma superclasse abstrata. 
por exemplo: se no meu banco apenas contas poupança e contas para empresas podem ser instanciadas a partir de uma conta comum, ou seja, não podem existir outras contas comuns além a conta pai, eu coloco o termo abstract na declaraç.ão da classe:
namespace ...{
abstract class Account{
...
}
a classe abstrata em uml é descrita em itálico

 */