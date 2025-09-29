using Tyuiu.SushchikIA.Sprint1.Task2.V17.Lib;


DataService ds = new DataService();
Console.Title = "Спринт #1 | Выполнил: Сущик И.А. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Сущик Игорь Александрович | ПИНб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
string value = Console.ReadLine();
int intValue = Convert.ToInt32(value);
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.ConvertMinutesToHours(intValue));
Console.ReadLine();