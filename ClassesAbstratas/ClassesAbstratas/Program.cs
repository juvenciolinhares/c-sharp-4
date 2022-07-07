using System;
using ClassesAbstratas.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ClassesAbstratas 
{
    class Program
    {
        static void Main(string[] args)
        {
            //criou uma lista do tipo account
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));


            //aplicação do polimorfismo:
            foreach (Account acc in list)
            {

                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {

                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
                /*
                 * das contas poupança vai sacar 7 reais
                 * das contas empresa vai saca 5 reais
                 */
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