using Tyuiu.ArkhipovaMD.Sprint4.Task3.V21.Lib;

DataService ds  = new DataService();



Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #21                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
int[,] array = new int[5, 5]
{
{ 8, 3, 3, 3, 5 },
{ 6, 7, 3, 3, 7 },
{ 4, 5, 4, 6, 6 },
{ 5, 5, 8, 8, 7 },
{ 4, 6, 6, 7, 7 }
};
foreach (int i in array)
{
    Console.Write(i + "\t");
}
Console.WriteLine();
Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");
Console.WriteLine(ds.Calculate(array));
