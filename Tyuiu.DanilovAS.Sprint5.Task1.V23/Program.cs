using System.Security.Cryptography;
using Tyuiu.DanilovAS.Sprint5.Task1.V23.Lib;
namespace Tyuiu.DanilovAS.Sprint5.Task1.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Данилов А.С. | ИИПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Данилов Александр Сергеевич | ИИПб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, произвести табулирование на заданном диапазоне [-5;5] с   *");
            Console.WriteLine("* шагом 1. Произвести проверку деление на ноль. При делении на ноль       *");
            Console.WriteLine("* вернуть значение 0. Результат сохранить в текстовый файл                *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить  *");
            Console.WriteLine("* до двух знаков после запятой.                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"* startValue = {startValue}                                                         *");
            Console.WriteLine($"* stopValue = {stopValue}                                                           *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue,stopValue);

            Console.WriteLine($"Файл {res} Создан!");
            Console.ReadKey();


        }
    }
}
