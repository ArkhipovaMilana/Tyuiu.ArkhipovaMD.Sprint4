using Tyuiu.ArkhipovaMD.Sprint4.Task5.V17.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task5.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[,] { { 1 }, { 2 }, { -3 } };
            var exp = 1;
            var res = ds.Calculate(array);
            Assert.AreEqual(exp, res);
        }
    }
}
