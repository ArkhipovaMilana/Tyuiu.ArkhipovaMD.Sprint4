using Tyuiu.ArkhipovaMD.Sprint4.Task5.V17.Lib;

DataService ds  = new DataService();
Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #17                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
int[,] array = new int[5,5];
for (int i =0 ; i < 5;i++)
{
    for (int j =0 ; j < 5;j++)
    {
        array[i, j] = 1;
    }
}
foreach (int i in array)
{
    Console.Write(i + "\t");
}

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.Calculate(array));