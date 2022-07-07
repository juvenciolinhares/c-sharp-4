
namespace metodosAbstratosExc2.Entities
{
    internal class Individual : Payers
    {
        public double HealtExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healtExpenditures) : base(name, anualIncome)
        {

            HealtExpenditures = healtExpenditures;
        }

        public override double TaxPaid()
        {
            if (AnualIncome < 20000.00)
            {
                return (AnualIncome * 0.15) - (HealtExpenditures * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealtExpenditures * 0.5);
            }
        }
    }
}

/*
 * renda <20000.00=> 15% de imposto
renda > 20000.00 => 25% de imposto
gastos com saude é abatido 50% do imposto, exemplo:
50000 * 25%(imposto do salario)= 12500 
gasto com saude: 2000(*50%)1000
imposto total fica: 11500.00

 */