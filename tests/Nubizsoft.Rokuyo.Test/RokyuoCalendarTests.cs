using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nubizsoft.Globalization.Test
{
    [TestClass]
    public class RokyuoCalendarTests
    {
        [TestMethod]
        public void RegularCycle()
        {
            var rokuyoCalendar = new RokuyoCalendar();
            Assert.AreEqual(RokuyoDay.Butsumetsu, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 5)));
            Assert.AreEqual(RokuyoDay.Taian, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 6)));
            Assert.AreEqual(RokuyoDay.Shakku, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 7)));
            Assert.AreEqual(RokuyoDay.Sensho, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 8)));
            Assert.AreEqual(RokuyoDay.Tomobiki, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 9)));
            Assert.AreEqual(RokuyoDay.Sakimake, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 10)));
        }

        [TestMethod]
        public void UnRegularCycle()
        {
            var rokuyoCalendar = new RokuyoCalendar();
            Assert.AreEqual(RokuyoDay.Butsumetsu, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 23)));
            Assert.AreEqual(RokuyoDay.Taian, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 24)));
            Assert.AreEqual(RokuyoDay.Sensho, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 25)));
            Assert.AreEqual(RokuyoDay.Tomobiki, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 26)));
            Assert.AreEqual(RokuyoDay.Sakimake, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 27)));
            Assert.AreEqual(RokuyoDay.Butsumetsu, rokuyoCalendar.GetRokuyo(new DateTime(2020, 1, 28)));
        }

        [DataTestMethod]
        [DataRow("06/07/2020", RokuyoDay.Taian)]
        [DataRow("05/07/2018", RokuyoDay.Taian)]
        public void TestSpecificDate(string date, RokuyoDay rokuyoDay)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            var rokuyoCalendar = new RokuyoCalendar();
            Assert.AreEqual(rokuyoDay, rokuyoCalendar.GetRokuyo(DateTime.ParseExact(date, "dd/mm/yyyy", provider)));
        }



    }
}
