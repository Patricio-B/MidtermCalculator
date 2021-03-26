using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Events;

namespace MidtermCalculator.Models
{
    public class GetInput
    {
        public event EventHandler<GetUserInput> UserInput;

        public void GetUserMenuInput(string userInput)
        {
            OnUserInput(userInput);
        }

        protected void OnUserInput(string userInput)
        {
            if (UserInput != null)
                UserInput(this, new GetUserInput() { UserMenuInput = userInput });
        }

        public void GetUserInputDigit(double userInput)
        {

            OnUserInput(userInput);
        }

        protected  void OnUserInput(double userInput)
        {

            if (UserInput != null)
                UserInput(this, new GetUserInput() { UserDigitInput = userInput });
        }
    }

}