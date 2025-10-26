using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task4.V27.Lib
{
    public class DataService : ISprint4Task4V27
    {
        public int Calculate(int[,] matrix)
        {
            int sumRes = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                { if (matrix[i,j]%2!=0)
                    {
                        sumRes += matrix[i,j];
                    }
                }
            }
            return sumRes;
        }
    }
}
