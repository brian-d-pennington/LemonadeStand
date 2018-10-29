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
        private string seasonTempRange;
        private string seasonHumidityRange;

        public Seasons()
        {

        }

        private void SeasonGenerator()
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
        }
    }

}
