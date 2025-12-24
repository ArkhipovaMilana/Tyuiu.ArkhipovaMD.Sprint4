
using Tyuiu.ArkhipovaMD.Sprint4.Task7.V2.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #11                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
string str = "597643158942";
int cnt = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(str[cnt]+" ");
        cnt++;
    }
    Console.WriteLine();
}
Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.Calculate(3,4,str));