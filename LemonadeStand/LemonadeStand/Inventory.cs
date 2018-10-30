using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int bagsOfLemons;
        public int gallonsOfSweetener;
        public int bagsOfIceOnHand;

        public Inventory()
        {
            bagsOfLemons = 0;
            gallonsOfSweetener = 0;
            bagsOfIceOnHand = 0;
        }

        public void CurrentInventory()
        {
            if (bagsOfLemons == 0 && gallonsOfSweetener == 0) // change conditional to round counter later
            {
                Console.WriteLine("At this point you have zero ingredients, of course, but this is what your inventory display will look like:");
                Console.WriteLine("Bags of Lemons: " + bagsOfLemons + " Gallons of Syrup: " + gallonsOfSweetener + " Bags of Ice: " + bagsOfIceOnHand);
            }
        }
    }
}
