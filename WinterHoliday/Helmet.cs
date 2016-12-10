using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinterHoliday
{
    class Helmet : IAccessory
    {
        public void showMe() { 
            Console.WriteLine("Wez ze soba kask!");
        }
    }
}
