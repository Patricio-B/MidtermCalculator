using System;
using System.Collections.Generic;
using System.Text;
using MidtermCalculator.Models;
using MidtermCalculator.Events;

namespace MidtermCalculator.Events
{
    public class SaveUserInput
    {
        List<double> userInputs = new List<double>();
        public void OnUserInput(object sender, GetUserInput inputEvent)
        {
            userInputs.Add(inputEvent.UserDigitInput);

        }
        public void PrintInputs()
        {
            foreach (double digit in userInputs)
            {
                Console.WriteLine(digit + " ");
            }
        }
    }
}
}
