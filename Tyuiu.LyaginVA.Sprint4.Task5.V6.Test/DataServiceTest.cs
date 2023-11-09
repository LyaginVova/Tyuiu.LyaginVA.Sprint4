using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LyaginVA.Sprint4.Task5.V6.Lib;

namespace Tyuiu.LyaginVA.Sprint4.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 2, 2, 0, -4, 1 },
                                            { -2, 0, -1, -4, -2 },
                                            { 0, 2, 1, -4, -3 },
                                            { -3, 0, 1, 2, -1 },
                                            { 2, 2, 1, -2, 0 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] { { 1, 1, 0, -4, 1 },
                                          { -2, 0, -1, -4, -2 },
                                          { 0, 1, 1, -4, -3 },
                                          { -3, 0, 1, 1, -1 },
                                          { 1, 1, 1, -2, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
