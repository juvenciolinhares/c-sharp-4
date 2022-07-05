

namespace HerancaIntroducao.Entities
{   //sintaxe herença:
    internal class BusinessAccount : Account
    {
        //atributo diferente 
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)//construtor da classe pai
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            //a conta empresa tem um limite de empréstimo, entao, antes de fazer o emprestimo:
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }

        }
    }
}
/* palavra PROTECTED
 * permite acesso a mesma classe e SUBCLASSES dentro e fora do assembly
 */
