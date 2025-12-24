using Tyuiu.ArkhipovaMD.Sprint4.Task6.V11.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] array = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            DataService ds = new DataService();
            var exp = 3;
            var res = ds.Calculate(array);
            Assert.AreEqual(exp, res);
        }
    }
}
