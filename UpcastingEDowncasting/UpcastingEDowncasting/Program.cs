using System;
using HerancaIntroducao.Entities;

namespace HerancaIntroducao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar um objeto account:
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING(conversao da subclasse para a superclasse)

            Account acc1 = bacc;//o compilador aceita por que a classe BusinessAccount É UMA CLASSE DE Account
           
            //dar um new na subclasse e atribuir essa instanciação para uma variavel da superclasse
            Account acc2 = new BusinessAccount(3, "Bob", 0.0, 200.00);

            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING(conversao Da superclasse para subclasse)

            BusinessAccount acc4 = (BusinessAccount)acc2;// pra funcionar preciso fazer o casting
            acc4.Loan(100.00);
            

            //não aceita os metodos de businessaccount pq ele é uma variável do tipo account e em account não existe o metodo Loan
            //acc2.Loan() acc2 

            //subclasses não podem ser convertidas uma em outro implicitamente, mesmo com casting da erro na hora da execução
            //BusinessAccount acc5 = (BusinessAccount)acc3; na execução isso vai quebrar,

            //OPERADOR IS:
            if(acc3 is BusinessAccount)//se acc3 for um BusinessAccount, faça a conversão.
            {
                //como isso é falso o programa falha, mas não dá erro.
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!");

            }

            if(acc3 is SavingsAccount)
            {
                //esse if é true então vou conseguir fazer essa conversão e chamar esse método
                SavingsAccount acc5 = acc3 as SavingsAccount;// palavra AS: uma outra forma de fazer casting
                acc5.UpdateBalance();//operação da classe SavingsAccount
                Console.WriteLine("Update!");
            }



        }
    }
}
/*
 OBS.: 
o DOWNCASTING É UMA OPERAÇÃO INSEGURA
só pode ser usado se, realmente necessário e tem que testar se a variável é do tipo que eu quero
pra testar isso é usado o operado is.
 */