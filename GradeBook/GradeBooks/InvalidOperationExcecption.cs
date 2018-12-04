using System;
using System.Runtime.Serialization;

namespace GradeBook.GradeBooks
{
    [Serializable]
    internal class InvalidOperationExcecption : Exception
    {
        public InvalidOperationExcecption()
        {
        }

        public InvalidOperationExcecption(string message) : base(message)
        {
        }

        public InvalidOperationExcecption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidOperationExcecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}