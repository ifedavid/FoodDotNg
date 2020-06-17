using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDotNg.Data
{
    public class Events :BaseModel
    {
        public string Organizer { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Duration(DateTime start, DateTime end)
        {
            TimeSpan duration = end - start;

            return duration.Days;
        }

        public string EventPost { get; set; }
    }
}
