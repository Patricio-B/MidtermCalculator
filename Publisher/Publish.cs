using System;
using MidtermCalculator.Models;
using MidtermCalculator.Interfaces;
using MidtermCalculator.Events;

namespace MidtermCalculator.Publish
{
    public class Publish<T> : IPublish<T>
    {
        //Defined datapublisher event
        public event EventHandler<CreateCalculationEvent<T>> DataPublisher;

        private void OnDataPublisher(CreateCalculationEvent<T> args)
        {
            var handler = DataPublisher;
            if (handler != null)
                handler(this, args);
        }


        public void PublishData(T data)
        {
            CreateCalculationEvent<T> message = (CreateCalculationEvent<T>)Activator.CreateInstance(typeof(CreateCalculationEvent<T>), new object[] { data });
            OnDataPublisher(message);
        }
    }
}
