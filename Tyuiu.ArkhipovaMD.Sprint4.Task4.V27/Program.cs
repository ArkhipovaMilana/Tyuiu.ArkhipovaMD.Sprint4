using Tyuiu.ArkhipovaMD.Sprint4.Task4.V27.Lib;

//DataService ds  = new DataService();
//int[,] array = new int[5,5];
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        array[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}
//Console.WriteLine(ds.Calculate(array));

int resm = 0;
for (int i = 0;i < 25; i++)
{
     int u = Convert.ToInt32(Console.ReadLine());
     if (u%2!= 0)
     {
        resm += u;
     }
}
Console.WriteLine(resm);