using Tyuiu.ArkhipovaMD.Sprint4.Task7.V2.Lib;

namespace Tyuiu.ArkhipovaMD.Sprint4.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "597643158942";
            int n = 3, m = 4;
            var res = ds.Calculate(n, m, str);
            var exp = 39;
            Assert.AreEqual(exp, res);
        }
    }
}
