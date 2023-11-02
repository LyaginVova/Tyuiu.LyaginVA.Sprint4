using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.LyaginVA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 6, 8, 9, 5, 7, 4, 8, 6, 9, 4, 7, 8, 9 };

            int res = ds.Calculate(numsArray);
            int wait = 46;

            Assert.AreEqual(wait, res);
        }
    }
}
