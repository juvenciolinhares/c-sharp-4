using System;
using System.Collections.Generic;
using ExcHerancaEPoliMorf2.Entities;
using System.Globalization;

namespace ExcHerancaEPoliMorf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criar lista 
            List<Product> list = new List<Product>();

            //dados dos produtos:
            Console.Write("Enter the number or products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.WriteLine("Common, used or imported?(c/u/i)");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (answer == 'c')
                {
                    list.Add(new Product(name, price));

                }
                else if (answer == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));

                }
                else 
                {

                    Console.Write("Manufactured Date(DD/MM/YYYY): ");
                    DateTime manufactured = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactured));
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.priceTag());
            }
        }
    }
}
