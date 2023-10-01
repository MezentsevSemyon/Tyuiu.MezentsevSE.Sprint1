using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MezentsevSE.Sprint1.Task6.V15.Lib;
namespace Tyuiu.MezentsevSE.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string x = "ааааа!";
            bool res = ds.CheckLettersCount(x);
            bool wat = true ;
            Assert.AreEqual(wat, res);
        }
    }
}
