using System;
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
    }
}
