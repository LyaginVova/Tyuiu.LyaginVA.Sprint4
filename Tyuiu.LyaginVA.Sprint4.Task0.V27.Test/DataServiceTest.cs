using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint4.Task0.V27.Lib;

namespace Tyuiu.LyaginVA.Sprint4.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = ds.GetMultOddArrEl(array);
            int wait = 6615;
            Assert.AreEqual(wait, res);
        }
    }
}
