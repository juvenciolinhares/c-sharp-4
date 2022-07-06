using System;
using SobrePosicaoVirtualOverrideBase.Entities;

namespace SobrePosicaoVirtualOverrideBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500.00);
            Account accpoup = new SavingsAccount(1002, "Ana", 500.00, 0.01);

            //saque nas duas contas:
            acc.Withdraw(10.0);
            accpoup.Withdraw(10.0);


            /*SOBREPOSIÇÃO
             reimplemento na sublclasse uma operação da superclasse, mas posso fazer alterações*/


            //conta comum é cobrada taxa de saque, conta poupança não é cobrada

            Console.WriteLine(acc.Balance);//sacou 10 reais + taxa de saque=> 485

            /*PALAVRA BASE: aproveita metodos superclasse+ alteração na subclasse*/
            Console.WriteLine(accpoup.Balance);//sacou 10 reais + 5 reais(taxa de saque superclasse(account)) + 2 reais(taxa de saque subclasse(savingsaccount))





        }
    }
}
/*SOBREPOSIÇÃO
reimplemento na sublclasse uma operação da superclasse, mas posso fazer alterações*/
/*PALAVRA BASE: 
 ja usei no reraproveitamento de construtores, alterando/adicionando os novos construtores na subclasse
 */