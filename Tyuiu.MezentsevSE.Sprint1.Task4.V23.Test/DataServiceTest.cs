using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MezentsevSE.Sprint1.Task4.V23.Lib;

namespace Tyuiu.MezentsevSE.Sprint1.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0;
            double form = 0.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(form, res);
        }
    }
}
