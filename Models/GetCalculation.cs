using System;
namespace MidtermCalculator.Models
{
    public class MessageArgument<T> : EventArgs
    {
        public T Message { get; private set; }
        public MessageArgument(T message)
        {
            Message = message;
        }
    }
}
