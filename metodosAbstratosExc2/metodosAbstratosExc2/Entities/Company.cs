
namespace metodosAbstratosExc2.Entities
{
    internal class Company : Payers
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxPaid()
        {
            if (NumberOfEmployees <= 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
/*
 * numero de func <=10, imposto: 16%
numero de func >10, imposto: 14%
exemplo: empresa com 14 func.:
 400000 *14 = 56.000

 */
