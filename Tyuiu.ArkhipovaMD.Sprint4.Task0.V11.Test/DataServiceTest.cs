﻿using Tyuiu.ArkhipovaMD.Sprint4.Task0.V11.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            int ans = 4725;
            int res = ds.GetMultOddArrEl(array);
            Assert.AreEqual(ans, res);
        }
    }
}
