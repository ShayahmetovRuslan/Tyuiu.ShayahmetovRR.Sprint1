using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint1.Task2.V16.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шаяхметов Р. Р.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры                                   *");
            Console.WriteLine("* Задание #2                                                           *");
            Console.WriteLine("* Вариант #16                                                          *");
            Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич  | АСОиУБ-23-1                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет периметр круга*");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: R = 1                                               *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine(ds.CalculatePerimetrCircle(1));
            Console.ReadKey();
        }
    }
}
