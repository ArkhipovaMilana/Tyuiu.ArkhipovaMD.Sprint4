using Tyuiu.ArkhipovaMD.Sprint4.Task2.V27.Lib;




Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #27                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");


Random random = new Random();
DataService ds = new DataService();
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i < len; i++)
{
    array[i] = random.Next(2, 7);
}

foreach (int i in array)
{
    Console.Write(i + "\t");
}

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.Calculate(array));