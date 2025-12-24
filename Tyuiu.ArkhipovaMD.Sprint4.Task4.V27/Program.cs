using Tyuiu.ArkhipovaMD.Sprint4.Task4.V27.Lib;

DataService ds = new DataService();



Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #27                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
int[,] array = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
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
//int resm = 0;
//for (int i = 0; i < 25; i++)
//{
//    int u = Convert.ToInt32(Console.ReadLine());
//    if (u % 2 != 0)
//    {
//        resm += u;
//    }
//}
//Console.WriteLine(resm);