using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint1.Task4.V3.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task4.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шаяхметов Р. Р.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: ClassMath                                                      *");
            Console.WriteLine("* Задание #4                                                           *");
            Console.WriteLine("* Вариант #3                                                           *");
            Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич  | АСОиУБ-23-1                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет результат по  *");
            Console.WriteLine("*                                                            формуле   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            double x, y;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("Результат вычисления по формуле равен: " + Math.Round(ds.Calculate(x, y), 3));
            Console.ReadLine();
        }
    }
}
