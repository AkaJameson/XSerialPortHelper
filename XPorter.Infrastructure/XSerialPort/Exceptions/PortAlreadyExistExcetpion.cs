using System;

namespace XPorter.Infrastructure.Exceptions
{
    public class PortAlreadyExistExcetpion:Exception
    {
        public PortAlreadyExistExcetpion()
        {
            
        }
        public PortAlreadyExistExcetpion(string message) : base(message)
        {

        }
        public PortAlreadyExistExcetpion(string message, Exception inner)
           : base(message, inner)
        {
        }
    }
}
