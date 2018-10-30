using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract class Store
    {
        public int bagOfIce = 2;
        public int shoppingBill;
        public List<int> shoppingList = new List<int>();


        public Store()
        {
        
        }

        public abstract void ShoppingCalculator();
        

    }
}

