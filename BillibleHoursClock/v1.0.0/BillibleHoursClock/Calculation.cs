using System;
using System.Collections.Generic;
using System.Text;

namespace BillibleHoursClock
{
    class Calculation
    {
        // adds up the hours based on time
        public string addUpHours(TimeSpan time)
        {
            decimal totalHours = time.Hours;

            decimal totalMinutes = time.Minutes;

            totalHours = totalMinutes / 60;


            return string.Format("{0:F}", totalHours);


        }
        // adds up the hours based on time and rate listed
        public string totalRate(decimal totalHours, decimal rate)
        {
            decimal totalBill;

            totalBill = totalHours * rate;

            return string.Format("{0:C}", totalBill);
        }
    }
}
