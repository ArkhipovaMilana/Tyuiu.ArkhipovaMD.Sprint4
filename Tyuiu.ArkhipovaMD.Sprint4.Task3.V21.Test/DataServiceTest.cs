using Tyuiu.ArkhipovaMD.Sprint4.Task3.V21.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds =    new DataService();
            var exp = 10290;
            int[,] array = new int[5, 5]
{
{ 8, 3, 3, 3, 5 },
{ 6, 7, 3, 3, 7 },
{ 4, 5, 4, 6, 6 },
{ 5, 5, 8, 8, 7 },
{ 4, 6, 6, 7, 7 }
};
            var res = ds.Calculate(array);
            Assert.AreEqual(exp, res);
        }
    }
}
