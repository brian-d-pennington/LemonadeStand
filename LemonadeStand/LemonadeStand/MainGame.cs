using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class MainGame
    {
        public Player player;
        public Seasons season;

        public MainGame()
        {
            player = new Player();
            season = new Seasons();
        }
        public void MainMenu()
        {
            DisplayInstructions();
            player.GetPlayerFirstName();
            GameOutline();
            season.SeasonGenerator();
            season.SeasonTempDisplay();
            
        }

        private void DisplayInstructions()
        {
            Console.WriteLine("WELCOME TO LEMONADE STAND");
            Console.WriteLine("-------------------------");
            Console.WriteLine("The goal of this game is to operate a profitable lemonade stand over the course of 7 days..");
            Console.WriteLine("..dealing and responding to different variables such as the weather and customer tastes..");
            Console.WriteLine("Would you like to proceed? type 'Yes' or 'No'");
            string toProceed = Console.ReadLine();
            if (toProceed == "no" || toProceed == "NO" || toProceed == "No")
            {
                Console.WriteLine("Odd, but okay..");
                System.Threading.Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Console.WriteLine("Every player will start with an unlimited supply of cups and work on the same busy downtown corner..");
            Console.WriteLine("(featuring all types: professionals, hourly workers, tourists, high end shoppers, etc.)..");
            Console.WriteLine("otherwise you get to choose the variables. Except for the season & daily weather.. can't control that ;)");
            Console.WriteLine("ALRIGHT.. IT'S TIME TO PLAY--------------------------------------------------------------");

        }

        private void GameOutline()
        {
            Console.WriteLine("Ok, " + player.playerName + ", you will start out with $" + player.GameInProgressBudget + ".");
            Console.WriteLine("You will need to guess your supply based on the weather and day of the week (weekends have less foot traffic downtown)");
            Console.WriteLine("You also need to decide who your market will be: everyday workers or high end clientele with pickier tastes");
            Console.WriteLine("The high end buyers will pay more for quality stuff, but there might not be as many out them. Also, they don't");
            Console.WriteLine("like going out in nasty weather in expensive clothes as much. So.. your call.");
            Console.WriteLine("OK... NOW LET'S TAKE A LOOK AT WHAT SEASON YOU'LL BE WORKING IN......");
            System.Threading.Thread.Sleep(12000);
        }
    }
}
