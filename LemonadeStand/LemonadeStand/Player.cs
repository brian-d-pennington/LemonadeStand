using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string playerName;
        private int playerBudget; // dollars, to start

        public int GameInProgressBudget
        {
            get
            {
                return playerBudget;
            }
            set
            {
                playerBudget = value;
            }
        }


        public Player()
        {
            playerName = "";
            playerBudget = 50; // dollars, to start
        }

        public void GetPlayerFirstName()
        {
            Console.WriteLine("Please enter your name: ");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome to " + playerName + "'s Lemonade Stand!");
        }

    }
}
