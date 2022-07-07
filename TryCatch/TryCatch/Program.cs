using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*ler dois numeros inteiros, realizar uma divisão e mostrar o resultado:
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int result = n1 / n2;=>se eu dividir um numero por 0 vai gerar uma exceção e vai quebrar o programa
            Console.WriteLine(result);
            

             resolvendo a exceção:

            vou TENTAR executar esse código
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
            se der erro, vou CAPTURAR essa exceção:
            estou usando DivideByZeroException pq é mais específico
            catch (DivideByZeroException)//o "e" é um "apelido" que eu dou pra exceção: 
            {
                Console.WriteLine("Division by zero is not allowed");// ele não quebra a aplicação, mas sim imprime a minha msg
            }                                
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            */

            //CÓDIGO LIMPO:
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine(result);
            }
           
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)//o "e" é um "apelido" que eu dou pra exceção: 
            {
                Console.WriteLine("Format error! " + e.Message);
            }

        }
    }
}
