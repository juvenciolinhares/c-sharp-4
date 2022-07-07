

namespace metodosAbstratosExc2.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payers()
        {
        }
        public Payers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxPaid();
    }
}
