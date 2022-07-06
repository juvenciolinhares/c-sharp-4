using System;
using System.Collections.Generic;
using System.Text;

namespace CassesEMetodosSelados.Entities
{
    //palavra sealed indica que essa classe nao tem classes herdeiras
    sealed class SavingsAccount : Account//heranca
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

        //essa operação ja foi sobrescrita, então não pode ser sobrescrita novamente(sealed)
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}

/*
 * PALAVRA SEALED:
 * posso usar pra selar uma classe, ou seja, não pode ser herdada(linha 8)
 * posso usar ainda para selar um método que ja foi herdado (linha 28)
 * 
*pra que selar uma classe?
 * 1- segurança: 
 * dependendo das regras de negócio é desejável garantir esse selo para classes e métodos.
 * geralmente métodos sobrepostos são uma porta de entrada para inconsistências.
 * 
 * 2- performance: atributos de uma classe selada são analisados de forma mais rápida em tempo de execução
 * exemplo: string
 */


