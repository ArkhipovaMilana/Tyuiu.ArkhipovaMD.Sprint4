using Tyuiu.ArkhipovaMD.Sprint4.Task4.V27.Lib;

DataService ds = new DataService();
int[,] array = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine(ds.Calculate(array));

