﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint1.Task1.V6.Lib;
namespace Tyuiu.MezentsevSE.Sprint1.Task1.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1, res);
        }
    }
}
