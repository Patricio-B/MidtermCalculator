using System;

namespace MidtermCalculator.Events
{
    public class GetUserInput
    {
        public event EventHandler<InputEvent> userInputEvent;

        public void GetNumbers(double userNum)
        {
            CheckInput(userNum);
        }

        //might not need this
        protected virtual void CheckInput(double userNum)
        {
            if (userNum != null)
            {
                userInputEvent(this, new InputEvent() { UserInput = userNum });
            }
        }

        public void UserCalculation(Func<double, double, double> userNum)
        {
            CheckInput(userNum);
        }

        protected virtual void CheckInput(Func<double, double, double> userNum)
        {
            userInputEvent.Invoke(this, new InputEvent() { UserCalculation = userNum });
        }
    }
}
