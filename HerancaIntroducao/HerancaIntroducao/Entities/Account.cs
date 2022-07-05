

namespace HerancaIntroducao.Entities
{
    internal class Account
    {
        public int Number { get;private set; }
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

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

