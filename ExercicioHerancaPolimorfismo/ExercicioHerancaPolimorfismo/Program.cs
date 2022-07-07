using System;
using System.Globalization;
using ExercicioHerancaPolimorfismo.Entities;
using System.Collections.Generic;

namespace ExercírioHerancaPolimorfismo

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lista que vai receber os funcionários(vazia)
            List<Employee> list = new List<Employee>();

            //dados dos funcionários
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee # {i} data:");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //testar se esse funcionário é terceirizado pra ler a despeza adicional dele.
                if (ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //adicionar um funcionário terceirizado na lista:
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    //adicionar um funcionário normal na lista:
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
/*
 * funcionários proprios
 * funcionarios tercerizados
 * registrar nome, horas trabalhadas e valor por hora
 * pagamento: valor da hora * horas trabalhadas
 * func terc> bonus: 110% de sua despesa adicional
 * 
 * ler os dados de n funcionários,
 * armazenar numa lista,
 * ler todos os dados
 * mostrar nome e pagamento de cada um na mesma ordem que foram digitados
 * 
 */