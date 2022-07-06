
namespace HerancaIntroducao.Entities
{


    internal class SavingsAccount : Account//heranca
    {
        public double InterestRate { get; set; }//taxa de juros

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
