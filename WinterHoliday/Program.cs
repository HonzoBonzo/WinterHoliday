using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterHoliday
{
    enum WYJAZD { SKI, SLEDGE, SNOWBOARD };
    class Program
    {
        static void Main(string[] args)
        {
            int typeOfHoliday = -1;
            Console.WriteLine("Wybierz rodzaj wyjazdu zimowego:\n0 - Ski\n1 - Sledge\n2 - Snowboard");
            try
            {
                typeOfHoliday = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Podales zla liczbe");
                throw;
            }
            Holiday wyjazd = new Holiday((WYJAZD)typeOfHoliday);
            wyjazd.showAccessories();
            Console.ReadKey();
        }
    }
}
