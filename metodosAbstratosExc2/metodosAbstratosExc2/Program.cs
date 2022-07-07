using System;
using System.Globalization;
using System.Collections.Generic;
using metodosAbstratosExc2.Entities;

namespace metodosAbstratosExc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Payers> list = new List<Payers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data:");
                Console.Write("Individual or company(i/c)? ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(answer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healtExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healtExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));

                }
                
                
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            //impostos cobrados individualmente e impostos totais:
            double sum = 0.0;
            foreach (Payers payers in list)
            {

                Console.WriteLine(payers.Name + ": $ " + payers.TaxPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += payers.TaxPaid();
            }

            //impostos totais:
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

