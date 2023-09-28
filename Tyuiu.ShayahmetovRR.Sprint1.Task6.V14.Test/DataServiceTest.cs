using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidException()
        {
            DataService ds = new DataService();
            string password = "бабаываб";
            Assert.AreEqual(true, ds.CheckLowerCaseRusLetters(password));

        }
    }
}
