using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExceprion()
        {
            DataService ds = new DataService();
            double f = 30;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(1, res);
        }
    }
}
