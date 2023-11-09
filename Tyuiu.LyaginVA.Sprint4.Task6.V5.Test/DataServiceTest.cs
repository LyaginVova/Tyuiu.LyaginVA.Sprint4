using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint4.Task6.V5.Lib;

namespace Tyuiu.LyaginVA.Sprint4.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var planets = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
            int res = ds.Calculate(planets);
            int wait = 1;
            Assert.AreEqual(wait, res); 
        }
    }
}
