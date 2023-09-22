using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint1.Task3.V1.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2.0;
            double h = 2.0;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(25.12, res);
        }
    }
}
