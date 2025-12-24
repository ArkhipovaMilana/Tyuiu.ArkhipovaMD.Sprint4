using Tyuiu.ArkhipovaMD.Sprint4.Task1.V3.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int len = 5;
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = i;
            }
            var res = ds.Calculate(array);
            var exp = 0;
            Assert.AreEqual(exp, res);
        }
    }
}
