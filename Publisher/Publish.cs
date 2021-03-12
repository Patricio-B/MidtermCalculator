using System;
using MidtermCalculator.Models;
using MidtermCalculator.Interfaces;
using System.Collections.Generic;
using System.Threading;

namespace MidtermCalculator.Publisher
{
    public class Publish : IPublish
    {
        // For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.

        // List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private List<IListen> _observers = new List<IListen>();

        // The subscription management methods.
        public void Attach(IListen observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IListen observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        // Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void PrintCalc()
        {

            Console.WriteLine("Print Calculation Test ");
            this.Notify();
        }
    }
}
