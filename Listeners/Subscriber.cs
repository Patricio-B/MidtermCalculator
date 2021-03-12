/*using System;
using MidtermCalculator.Models;
using MidtermCalculator.Interfaces;

namespace MidtermCalculator.Listeners
{
    public class Subscriber
    {


        public IPublish<T> Publisher { get; private set; }
        public Subscriber(IPublish<T> publisher)
        {
            Publisher = publisher;
        }



        /*Subscription<Mymessage> myMessageToken;
        //Subscription<int> intToken;
        CalculatorManager calculatorManager;

        public Subscriber(CalculatorManager eve)
        {
            calculatorManager = eve;
            //eve.Subscribe<Mymessage>(this.Test);
            eve.Subscribe<int>(this.IntTest);
        }

        private void IntTest(int obj)
        {
            Console.WriteLine(obj);
            calculatorManager.UnSbscribe(intToken);
        }

        private void Test(Mymessage test)
        {
            Console.WriteLine(test.ToString());
            //calculatorManager.UnSbscribe(myMessageToken);
        }
    }
}*/
