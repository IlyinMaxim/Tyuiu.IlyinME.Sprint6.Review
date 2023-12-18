using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IlyinME.Sprint6.TaskReview.V20.Lib;

namespace Tyuiu.IlyinME.Sprint6.TaskReview.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int K = 0;
            int L = 3;
            int R = 1;
            int[,] array = new int[4, 4]  { { 6, -3, 1, -5},
                                            { 216, -27, 1, -125},
                                            { 6, -4, 6, -4 },
                                            { 216, -64, 216, -64 }};
            int res = ds.ResultGetMatrix(array, R, K, L);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
