
namespace ClassesAbstratas.Entities
{
    abstract class Account//tranformou em classe abstrata, ou seja, não consigo instanciar objetos account.
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
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
