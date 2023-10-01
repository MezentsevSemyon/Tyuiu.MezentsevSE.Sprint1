using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint1.Task7.V25.Lib;
namespace Tyuiu.MezentsevSE.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wat = 1.9 ;
            Assert.AreEqual(wat, res);
        }
    }
}
