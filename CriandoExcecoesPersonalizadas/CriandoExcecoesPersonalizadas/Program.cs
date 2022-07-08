using System;
using CriandoExcecoesPersonalizadas.Entities;
using CriandoExcecoesPersonalizadas.Entities.Exceptions;

namespace CriandoExcecoesPersonalizadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vou TENTAR EXECUTAR MEU CÓDIGO
            try
            {
                //esse bloco linear(sem if-else) é chamado de CENÁRIO

                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                //instanciar a reserva:
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                //atualizar reserva:
                Console.Write("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                //atualização:
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)//caso dê erro, vou tratar as possivei exceções:
            {
                //possivei exceções: 2 no metodo updateDates, 1 no construtor.
                Console.WriteLine("Error in reservation: " + e.Message);//se acontecer um exceção domainexception, imprimo a msg de erro personalizada.

            }
            //captura de um possível erro room number
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            //exceção genérica pra capturar outro tipo de exceção que naõ percebi.
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }

    }
}

/*ler os dados de uma reserva num hotel
 * num do quarto
 * data de entrada 
 * data de saida
 *  mostrar os dados da reserva inclusive com a duração em dias
 *  em seguida ler novas datas de entrada e saída e atualizar a reserva, mostrando novamente na tela
 *  
 *  o programa não deve aceitar dados inválidos na reserva conforme regras:
 *  -alteração de reserva só pode ocorrer para datas futuras
 *  -a data de saída deve ser maior que a de entrada 
 *  
 *  application exception: personalizar minhas exceções.
 *  
 *  a lógica de tratar os erros está na classe onde o erro pode acontecer e não no programa principal
construtores podem ter exceções

código mais simples sem aninhamento de condicionais

é possivel capturar outras exceções de sistema

 */
