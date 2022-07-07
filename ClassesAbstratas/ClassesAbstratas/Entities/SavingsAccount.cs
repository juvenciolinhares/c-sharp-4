namespace ClassesAbstratas.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

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

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
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