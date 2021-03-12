using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermCalculator.Interfaces
{
    public interface IListen
    {
        // Receive update from subject
        void Update(IPublish subject);
    }
}
