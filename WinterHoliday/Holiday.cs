using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinterHoliday
{
    class Holiday //strategy, builder
    {
        List<IAccessory> listOfAccessories;
        public Holiday(WYJAZD typeOfHoliday)
        {
            listOfAccessories = new List<IAccessory>();
            switch (typeOfHoliday) {
                case WYJAZD.SKI:
                    listOfAccessories.Add(new Skis());
                    listOfAccessories.Add(new Helmet());
                    break;
                case WYJAZD.SLEDGE:
                    listOfAccessories.Add(new Sledge());
                    listOfAccessories.Add(new Helmet());
                    break;
                case WYJAZD.SNOWBOARD:
                    listOfAccessories.Add(new Snowboard());
                    listOfAccessories.Add(new Helmet());
                    break;
            }

            listOfAccessories.Add(new Pants());
            listOfAccessories.Add(new Coat());
            listOfAccessories.Add(new Gloves());
            listOfAccessories.Add(new Hat());
        }

        public void showAccessories() {
            foreach (IAccessory item in listOfAccessories)
            {
                item.showMe();
            }
        }
    }
}
