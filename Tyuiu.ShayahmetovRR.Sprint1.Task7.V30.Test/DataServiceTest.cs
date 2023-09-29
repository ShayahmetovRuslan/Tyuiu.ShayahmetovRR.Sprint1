using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint1.Task7.V30.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidException()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(0, 0);
            Assert.AreEqual(1, res);
        }
    }
}
