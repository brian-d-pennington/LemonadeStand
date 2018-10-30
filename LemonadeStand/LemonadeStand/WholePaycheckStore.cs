using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class WholePaycheckStore:Store
    {
        public int wholeOrganicLemons = 5;
        public int wholeAgaveSyrupGallon = 7;

        public override void ShoppingCalculator()
        {
            int lemonBill = shoppingList[0] * wholeOrganicLemons;
            int sugarBill = shoppingList[1] * wholeAgaveSyrupGallon;
            int iceBill = shoppingList[2] * bagOfIce;
            shoppingBill = lemonBill + sugarBill + iceBill;
            Console.WriteLine("Your Whole Paycheck bill comes out to $" + shoppingBill);
        }
    }
}
