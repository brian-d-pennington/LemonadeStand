using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class OldiStore:Store
    {
        public int oldiMoldiBagOfLemons = 2;
        public int oldiGallonOfBeetusSyrup = 2;



        public override void ShoppingCalculator()
        {
            int lemonBill = shoppingList[0] * oldiMoldiBagOfLemons;
            int sugarBill = shoppingList[1] * oldiGallonOfBeetusSyrup;
            int iceBill = shoppingList[2] * bagOfIce;
            shoppingBill = lemonBill + sugarBill + iceBill;
            Console.WriteLine("Your OLDI bill comes out to $" + shoppingBill);
        }
    }

    
}
