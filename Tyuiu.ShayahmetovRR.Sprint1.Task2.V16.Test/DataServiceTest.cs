﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShayahmetovRR.Sprint1.Task2.V16.Lib;
namespace Tyuiu.ShayahmetovRR.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 1;
            var res = ds.CalculatePerimetrCircle(r);
            Assert.AreEqual(6.28, res);
        }
    }
}
