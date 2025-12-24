using Tyuiu.ArkhipovaMD.Sprint4.Task0.V11.Lib;
//{ 8, 9, 5, 4, 3, 2, 1, 0, 5, 7}
DataService ds = new DataService();


Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #11                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
int[] array = new int[10];
array[0] = 8;
array[1] = 9;
array[2] = 5;
array[3] = 4;
array[4] = 3;
array[5] = 2;
array[6] = 1;
array[7] = 0;
array[8] = 5;
array[9] = 7;
foreach (int i in array)
{
    Console.Write(i + "\t");
}

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.GetMultOddArrEl(array));
