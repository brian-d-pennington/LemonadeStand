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
        public Inventory inventory;
        public Store store;

        public int roundCount = 0; // implemented to avoid redundant instructions
        

        public MainGame()
        {
            player = new Player();
            season = new Seasons();
            inventory = new Inventory();
        }
        public void MainMenu()
        {
            DisplayInstructions();
            player.GetPlayerFirstName();
            GameOutline();
            season.SeasonGenerator();
            season.SeasonTempDisplay();
            ChoiceOfStore();
            inventory.CurrentInventory();
            RoundCounter();
            TripToTheStore();
            store.ShoppingCalculator();
            BudgetCheck();
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
            else if (toProceed.ToLower() != "yes")
            {
                Console.WriteLine("Please type more carefully.");
                DisplayInstructions();
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
            Console.WriteLine("The high end buyers will pay more for quality stuff, but there might not be as many of them. Also, they don't");
            Console.WriteLine("like going out in nasty weather in expensive clothes as much. So.. your call.");
            Console.WriteLine("OK... NOW LET'S TAKE A LOOK AT WHAT SEASON YOU'LL BE WORKING IN......");
            System.Threading.Thread.Sleep(2000); //change back to 12000 later
        }

        private void ChoiceOfStore()
        {
            string storeChoice;
            if (roundCount == 0)
            {
                Console.WriteLine("Ok, keep this weather in mind as you stock up on ingredients at the store.");
                Console.WriteLine("(you will sell the most in warm weather obviously, but you can save on ice in cold weather, etc.)");
                Console.WriteLine("Now, you need to decide on whether to shop at the OLDI to make a cheap, servicable lemonade..");
                Console.WriteLine("or you can shop at the WHOLE PAYCHECK and buy fancy ingredients some people will pay more for.");
                Console.WriteLine("RECIPE: it takes 1 bag of juiced lemons to serve 40 customers.");
                Console.WriteLine("1 to 1 is the recommended recipe but you can attempt to cut corners if you wish...");
                Console.WriteLine("Ice is not required but your customers will pretty much insist on it in hot weather");
                Console.WriteLine("Your business will open on a Monday, where you will get 150 potential weekday customers..");
                Console.WriteLine("Weekend days are a little thinner at around 80 potential customers, but still enough to operate");
                Console.WriteLine("Sooooo..");
            }
            Console.WriteLine("Do you want to shop at OLDI or WHOLE PAYCHECK? type: 'OLDI' or 'Whole'");
            storeChoice = Console.ReadLine();
            if (storeChoice.ToLower() == "oldi")
            {
                player.playerStoreChoice = "oldi";
            }
            else if (storeChoice.ToLower() == "whole")
            {
                player.playerStoreChoice = "whole paycheck";
            }
            else
            {
                Console.Write("Not a valid choce.. try again. And now you get to read all this again ha ha");
                System.Threading.Thread.Sleep(2000);
                ChoiceOfStore();
            }
            Console.WriteLine("Ok, " + player.playerStoreChoice.ToUpper() + " it is!");


        }
        private int RoundCounter()
        {
            return roundCount++;
        }
        public void TripToTheStore()
        {
            Console.WriteLine("How many bags of lemons do you need to buy");
            int lemonsToBuy = Int32.Parse(Console.ReadLine());
            inventory.bagsOfLemons = lemonsToBuy + inventory.bagsOfLemons;

            Console.WriteLine("How many gallons of syrup do you need to buy");
            int gallonsOfSyrupToBuy = Int32.Parse(Console.ReadLine());
            inventory.gallonsOfSweetener = gallonsOfSyrupToBuy + inventory.gallonsOfSweetener;

            Console.WriteLine("How many bags of ice do you need to buy");
            int bagsOfIceToBuy = Int32.Parse(Console.ReadLine());
            inventory.bagsOfIceOnHand = bagsOfIceToBuy + inventory.bagsOfIceOnHand;
            store.shoppingList.Add(lemonsToBuy);
            store.shoppingList.Add(gallonsOfSyrupToBuy);
            store.shoppingList.Add(bagsOfIceToBuy);
        }

        private void BudgetCheck()
        {
            if (player.GameInProgressBudget - store.shoppingBill <= 0)
            {
                Console.WriteLine("Uh oh, you don't have the budget to make that purchase. Go back to the store.");
                TripToTheStore();
                store.ShoppingCalculator();
                
            }
        }
    }
}
