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
            int R = 2;
            int[,] array = new int[5, 5]  { { 6, -3, 1, -5, 4},
                                            { 216, -27, 1, -125, 64},
                                            { 2, -4, -1, 4, 2 },
                                            { 8, -64, -1, 64, 8 },
                                            { 3, -4, 2, -1, 4 } };
            int res = ds.ResultGetMatrix(array, R, K, L);
            int wait = -1;
            Assert.AreEqual(wait, res);
        }
    }
}
