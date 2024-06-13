using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class VenueRental
    {
        DateTime date;

        public VenueRental(DateTime date)
        {
            this.date = date;
        }

        public double CalculateRentalPrice(DateTime date, int WeekdayPrice, int WeekendPrice)
        {
            WeekdayPrice = 100;
            WeekendPrice = 150;
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Det er weekend. Prisen for at leje lokalet er:" + WeekendPrice + "DKK");
                return WeekendPrice;
            }
            else
            {
                Console.WriteLine("Det er hverdag. Prisen for at leje lokalet er:" + WeekdayPrice + "DKK");
                return WeekdayPrice;
            }
        }
    }
}
