using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class MainGame
    {
        public void DisplayInstructions()
        {
            Console.WriteLine("WELCOME TO LEMONADE STAND");
            Console.WriteLine("-------------------------");
            Console.WriteLine("The goal of this game is to operate a profitable lemonade stand over the course of 7 days..");
            Console.WriteLine("..dealing and responding to different variables such as the weather and customer tastes..");
            Console.WriteLine("Would you like to proceed? type Yes or No");
            string toProceed = Console.ReadLine();
            if (toProceed != "yes" || toProceed != "YES" || toProceed != "Yes")
            {
                Console.WriteLine("please type more carfully");
                DisplayInstructions();
            }
            else if (toProceed == "no" || toProceed == "NO" || toProceed == "No")
            {
                Console.WriteLine("Odd, but okay..");
                //program exit
            }
            Console.WriteLine("Every player will start with an unlimited supply of cups and work on the same busy downtown corner..");
            Console.WriteLine("(featuring all types: professionals, hourly workers, tourists, high end shoppers, etc.)..");
            Console.WriteLine("otherwise you get to choose the variables. Except for the season & daily weather.. can't control that ;)");
            Console.WriteLine("ALRIGHT.. IT'S TIME TO PLAY--------------------------------------------------------------");

        }
    }
}
