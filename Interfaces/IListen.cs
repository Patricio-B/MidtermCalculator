using System;
namespace MidtermCalculator.Interfaces
{
    public interface IListen<TEventType>
    {
        void OnEventHandler(TEventType e);
    }
}
