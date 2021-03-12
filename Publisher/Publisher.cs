using System;
using MidtermCalculator.Models;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.Publish
{
    public class Publish<T> : IPublish<T>
    {
        //Defined datapublisher event
        public event EventHandler<MessageArgument<T>> DataPublisher;

        private void OnDataPublisher(MessageArgument<T> args)
        {
            var handler = DataPublisher;
            if (handler != null)
                handler(this, args);
        }


        public void PublishData(T data)
        {
            MessageArgument<T> message = (MessageArgument<T>)Activator.CreateInstance(typeof(MessageArgument<T>), new object[] { data });
            OnDataPublisher(message);
        }
    }
}
