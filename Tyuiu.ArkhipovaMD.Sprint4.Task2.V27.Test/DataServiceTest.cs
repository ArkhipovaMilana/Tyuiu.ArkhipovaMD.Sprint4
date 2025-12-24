using Tyuiu.ArkhipovaMD.Sprint4.Task2.V27.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var exp = 14;
            int len = 3;
            int[] array = [6, 6, 2];
            var res = ds.Calculate(array);
            Assert.AreEqual(exp, res);
        }
    }
}
