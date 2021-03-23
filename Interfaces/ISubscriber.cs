using System;
namespace MidtermCalculator.Interfaces
{
    public interface ISubscriber<TEventType>
    {
        void OnEventHandler(TEventType e);
    }
}
