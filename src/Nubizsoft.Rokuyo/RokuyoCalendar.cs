using System;
using System.Globalization;

namespace Nubizsoft.Globalization
{

    [Serializable]
    [System.Runtime.InteropServices.ComVisible(true)]
    public class RokuyoCalendar : JapaneseLunisolarCalendar
    {
        /// <summary>
        /// Calculates the rokuyo day in the specified date.
        /// </summary>
        /// <param name="time">The <see cref="DateTime"/> to read.</param>
        /// <returns>One of the <see cref="RokuyoDay"/> values that represents the day specified in the <paramref name="time"/> parameter.</returns>
        public RokuyoDay GetRokuyo(DateTime time)
        {
            return (RokuyoDay)((GetOldMonth(time) + GetDayOfMonth(time)) % 6);
        }

        /// <summary>
        /// Returns the month of the specified date according to the old calendar.
        /// </summary>
        /// <param name="time">The <see cref="DateTime"/> to read.</param>
        /// <returns>An integer from 1 to 13 that represents the month specified in the <paramref name="time"/> parameter.</returns>
        public int GetOldMonth(DateTime time)
        {
            var newYearDate = this.AddDays(time, 1 - this.GetDayOfYear(time));
            var leapMonth = this.GetLeapMonth(this.GetYear(newYearDate), this.GetEra(newYearDate));
            var oldMonth = this.GetMonth(time);
            return (0 < leapMonth) && (leapMonth <= oldMonth) ? oldMonth - 1 : oldMonth;
        }

    }
}