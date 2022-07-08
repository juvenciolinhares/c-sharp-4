using System;
namespace CriandoExcecoesPersonalizadas.Entities.Exceptions
{
    internal class DomainException : ApplicationException // domain é subclasse de applicationexception
    {
        //construtor que repassa a msg para o construtor da classe application exception
        public DomainException(string message) : base(message)
        {
        }
    }
}
/*
 * application exception: personalizar minhas exceções.
 * */
