using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KushnerovIA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.KushnerovIA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int x = 2;
            int y = 3;
            int z = 4;
            int res = DataService.Calc(x, y, z);
            Assert.AreEqual(45, res);
        }
    }
}