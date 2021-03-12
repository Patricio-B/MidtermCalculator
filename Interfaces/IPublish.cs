﻿using System;
using MidtermCalculator.Events;
using MidtermCalculator.Publisher;

namespace MidtermCalculator.Interfaces
{
    public interface IPublish<T>
    {
        event EventHandler<CreateCalculationEvent<T>> DataPublisher;
        //void OnDataPublisher(MessageArgument<T> args);
        void PublishData(T data);
    }
}
