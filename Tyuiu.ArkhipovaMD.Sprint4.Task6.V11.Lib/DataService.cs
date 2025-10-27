using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task6.V11.Lib
{
    public class DataService : ISprint4Task6V11
    {
        public int Calculate(string[] array)
        {
            int cnt = 0;
            foreach (var item in array)
            {
                if (item.Length == 5)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
