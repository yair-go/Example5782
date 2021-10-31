using System;
using System.Runtime.Serialization;

namespace Lesson4
{
    [Serializable]
    internal class WrongInputExpetion : Exception
    {
        public WrongInputExpetion()
        {
        }

        public WrongInputExpetion(string message) : base(message)
        {
        }

        public WrongInputExpetion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongInputExpetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}