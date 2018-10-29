using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Seasons
    {
        List<string> seasons = new List<string>() { "Winter", "Spring", "Summer", "Fall" };

        public string seasonAssigned;
        public int seasonTempRangeLo;
        public int seasonTempRangeHi;
        public int seasonHumidityAverage;

        public Seasons()
        {

        }

        public void SeasonGenerator()
        {
            Random r = new Random();
            int season = r.Next(0, 3);
            if (season == 0)
            {
                seasonAssigned = seasons[0];
            }
            else if (season == 1)
            {
                seasonAssigned = seasons[1];
            }
            else if (season == 2)
            {
                seasonAssigned = seasons[2];
            }
            else
            {
                seasonAssigned = seasons[3];
            }
            Console.WriteLine("..looks like you'll be operating in " + seasonAssigned + ". Plan wisely!");
        }

        public void SeasonTempDisplay()
        {
            if (seasonAssigned == seasons[0])
            {
                seasonTempRangeLo = 20; // degrees F
                seasonTempRangeHi = 55;
                seasonHumidityAverage = 30; // %
            }
            else if (seasonAssigned == seasons[2])
            {
                seasonTempRangeLo = 65;
                seasonTempRangeHi = 100;
                seasonHumidityAverage = 60;
            }
            else // fall & spring are similar
            {
                seasonTempRangeLo = 40;
                seasonTempRangeHi = 75;
                seasonHumidityAverage = 45;
            }

            Console.WriteLine("The afternoon high ranges from " + seasonTempRangeLo + " to " + seasonTempRangeHi);
            Console.WriteLine("with an average humidity of " + seasonHumidityAverage+ "%");
        }
    }

}
