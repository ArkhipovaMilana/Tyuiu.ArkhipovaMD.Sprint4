using Tyuiu.ArkhipovaMD.Sprint4.Task3.V21.Lib;

DataService ds  = new DataService();
int[,] ar = new int[5, 5]
{
{ 8, 3, 3, 3, 5 },
{ 6, 7, 3, 3, 7 },
{ 4, 5, 4, 6, 6 },
{ 5, 5, 8, 8, 7 },
{ 4, 6, 6, 7, 7 }
};
Console.WriteLine(ds.Calculate(ar));
