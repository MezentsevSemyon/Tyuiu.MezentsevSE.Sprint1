using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint1.Task3.Lib;
namespace Tyuiu.MezentsevSE.Sprint1.Task3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 67;
            double y = 8.5;
            double z = 6.5;
            double rast = 74.04;
            var res = Math.Round(ds.TravelCost(x,y,z),2);
            Assert.AreEqual(rast, res);

        }
    }
}
