
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ArkhipovaMD.Sprint4.Task3.V21.Lib
{
    public class DataService : ISprint4Task3V21
    {
        public int Calculate(int[,] array)
        {
            int res = 1;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                res *= array[i, array.GetLength(1)-1];
            }
            return res;
        }
    }
}
