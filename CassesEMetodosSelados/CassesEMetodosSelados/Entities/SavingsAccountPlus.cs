using System;
using System.Collections.Generic;
using System.Text;

namespace CassesEMetodosSelados.Entities
{   /*
    * ESSA CLASSE TENTA HERDAR DE SAVINGSACCOUNT, mas não consegue por que savingsaccount está selada
    */
    internal class SavingsAccountPlus : //SavingsAccount;=> não é permitido
        
    {   //esse método em savingsaccount JA FOI HERDADO E ESTÁ SELADO, portanto não é possivel implementar ele aqui
      
        /* public override void Withdraw(double amount)
        {

        } 
       */

    }
}
/*pra que selar uma classe?
 * 1- segurança: 
 * dependendo das regras de negócio é desejável garantir esse selo para classes e métodos.
 * geralmente métodos sobrepostos são uma porta de entrada para inconsistências.
 * 
 * 2- performance: atributos de uma classe selada são analisados de forma mais rápida em tempo de execução
 * exemplo: string
 * 
 */