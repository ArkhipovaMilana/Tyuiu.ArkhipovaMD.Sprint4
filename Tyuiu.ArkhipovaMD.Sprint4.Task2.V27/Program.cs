using Tyuiu.ArkhipovaMD.Sprint4.Task2.V27.Lib;

Random random = new Random();
DataService ds  = new DataService();
int len = Convert.ToInt32(Console.ReadLine());
int[] ar = new int[len];
for  (int i = 0; i < len; i++)
{
    ar[i] = random.Next(2, 7);
}
Console.WriteLine(ds.Calculate(ar))
    ;