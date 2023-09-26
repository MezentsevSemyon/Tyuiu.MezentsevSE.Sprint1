using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint1.Task2.V29.Lib;

namespace Tyuiu.MezentsevSE.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 3600;
            var res = ds.ConvertSecondsToHours(x);
            Assert.AreEqual(1, res);

        }
    }
}
