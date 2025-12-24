using Tyuiu.ArkhipovaMD.Sprint4.Task4.V27.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var exp = 3;
            int[,] array = new int[,] { { 1 },{ 1 },{ 1 } };
            var res = ds.Calculate(array);
            Assert.AreEqual(exp, res);
        }
    }
}
