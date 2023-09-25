using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint1.Task4.V3.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidException()
        {
            DataService ds = new DataService();

            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);

            Assert.AreEqual(3, res);
        }
    }
}
