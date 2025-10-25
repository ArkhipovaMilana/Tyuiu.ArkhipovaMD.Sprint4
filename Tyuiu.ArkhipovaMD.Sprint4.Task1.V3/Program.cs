using Tyuiu.ArkhipovaMD.Sprint4.Task1.V3.Lib;

DataService ds  = new DataService();
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i < len; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(ds.Calculate(array));