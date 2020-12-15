using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class CalendarExercises
    {
        /// <summary>
        /// Calculates number of business days, taking into account:
        ///  - weekends (Saturdays and Sundays)
        ///  - bank holidays in the middle of the week
        /// </summary>
        /// <param name="firstDay">First day in the time interval</param>
        /// <param name="lastDay">Last day in the time interval</param>
        /// <param name="bankHolidays">List of bank holidays excluding weekends</param>
        /// <returns>Number of business days during the 'span'</returns>
        public int BusinessDaysUntil(DateTime firstDay, DateTime lastDay)
        {
            firstDay = firstDay.Date;
            lastDay = lastDay.Date;
            if (firstDay > lastDay)
                throw new ArgumentException("Incorrect last day " + lastDay);

            TimeSpan span = lastDay - firstDay;
            int businessDays = span.Days + 1;
            int fullWeekCount = businessDays / 7;
            // find out if there are weekends during the time exceedng the full weeks
            if (businessDays > fullWeekCount * 7)
            {
                // we are here to find out if there is a 1-day or 2-days weekend
                // in the time interval remaining after subtracting the complete weeks
                int firstDayOfWeek = (int)firstDay.DayOfWeek;
                int lastDayOfWeek = (int)lastDay.DayOfWeek;
                if (lastDayOfWeek < firstDayOfWeek)
                    lastDayOfWeek += 7;
                if (firstDayOfWeek <= 6)
                {
                    if (lastDayOfWeek >= 7)// Both Saturday and Sunday are in the remaining time interval
                        businessDays -= 2;
                    else if (lastDayOfWeek >= 6)// Only Saturday is in the remaining time interval
                        businessDays -= 1;
                }
                else if (firstDayOfWeek <= 7 && lastDayOfWeek >= 7)// Only Sunday is in the remaining time interval
                    businessDays -= 1;
            }

            // subtract the weekends during the full weeks in the interval
            businessDays -= fullWeekCount + fullWeekCount;

            return businessDays;
        }

        // Interview question / answer. 
        public int WorkingDays(DateTime start, DateTime end)
        {
            // ren dato

            // ren uge
            // start - ryk frem hverdag
            // end - ryk tilbage hverdag

            var days = DatesInRange(start, end);

            var weekdays = days.Where(x => x.DayOfWeek != DayOfWeek.Saturday && x.DayOfWeek != DayOfWeek.Sunday);

            return weekdays.Count();

            // 
        }

        private List<DateTime> DatesInRange(DateTime start, DateTime end)
        {
            TimeSpan st = end.Date - start.Date;;

            var totalDays = st.Days + 1; // Little hach added after interview to handle missing day when time of day is same or overlapping. Might not work with actual times.

            List<DateTime> days = new List<DateTime>();

            for (var i = 0; i < totalDays; i++)
            {
                days.Add(start.Date.AddDays(i));
            }

            return days;
        }

    }
}
