using System;
using CriandoExcecoesPersonalizadas.Entities.Exceptions;//ter acesso a domainexceptions


namespace CriandoExcecoesPersonalizadas.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            //se a data final for menor ou igual a inicia, lanço uma exceção:
            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }

        //duração da reserva em diárias:
        public int Duration()
        {
            //timespan: duração de tempo; uso o método subtract do tipo timespan pra diminuir checkout-checkin
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            //pegar essa duração em dias:
            return (int)duration.TotalDays;//totalday é um double, então precisa de um casting
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;//não utilizo no meu código, mas no da video-aula sim.
            if (checkIn < CheckIn || checkOut < CheckOut)
            {
                //lançar uma nova excessão com a frase no argutmento:
                throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)//2- a data de saída menor que data de entrada
            {
                //lançar uma nova excessão com a frase no argutmento:
                throw new DomainException("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")//mascara de formatação da data 
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";

        }
    }
}
