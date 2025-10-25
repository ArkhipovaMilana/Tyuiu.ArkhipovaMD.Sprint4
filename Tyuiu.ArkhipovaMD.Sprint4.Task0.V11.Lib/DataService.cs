using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ArkhipovaMD.Sprint4.Task0.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
            int resMul = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    resMul *= array[i];
                }
            }
            return resMul;
        }
    }
}
