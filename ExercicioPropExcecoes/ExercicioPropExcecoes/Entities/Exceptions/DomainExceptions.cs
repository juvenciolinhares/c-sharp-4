using System;
namespace ExercicioPropExcecoes.Entities.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
            Console.WriteLine();
        }
    }
}
