using System;

namespace BashSoft.Exceptions
{
    class InvalidStringException : Exception
    {
        private const string InvalidStringMessage = "The value cannot be null or empty";

        public InvalidStringException()
            :base(InvalidStringMessage)
        {
        }

        public InvalidStringException(string message)
            : base(message)
        {
        }
    }
}
