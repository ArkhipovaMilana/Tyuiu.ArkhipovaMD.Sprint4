using Tyuiu.ArkhipovaMD.Sprint4.Task6.V11.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Архипова М.Д. | АСОиУб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #11                                                              *");
Console.WriteLine("* Выполнила: Архипова М.Д. | АСОиУб-25-1                                  *");
Console.WriteLine("***************************************************************************");
string[] array = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
foreach (string i in array)
{
    Console.Write(i + "\t");
}

Console.WriteLine("###########################################################################");
Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
Console.WriteLine("###########################################################################");

Console.WriteLine(ds.Calculate(array));