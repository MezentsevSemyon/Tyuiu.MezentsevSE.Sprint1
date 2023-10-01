using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MezentsevSE.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MezentsevSE.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 10;
            int n = 3;
            int res = ds.Calculate(k);
            Assert.AreEqual(n,res);
        }
    }
}
