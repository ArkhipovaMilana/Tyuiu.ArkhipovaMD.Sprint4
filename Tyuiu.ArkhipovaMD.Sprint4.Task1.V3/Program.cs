using Tyuiu.ArkhipovaMD.Sprint4.Task1.V3.Lib;

DataService ds  = new DataService();







Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");

int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i < len; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
foreach (int i in array)
{
    Console.Write(i + "\t");
}

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.Calculate(array));
