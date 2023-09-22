using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint1.Task3.V1.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шаяхметов Р. Р.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Арифметические операторы в С#                                  *");
            Console.WriteLine("* Задание #3                                                           *");
            Console.WriteLine("* Вариант #1                                                           *");
            Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич  | АСОиУБ-23-1                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет объем цилиндра*");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            double r, h;
            Console.WriteLine("Введите значение R: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("************************************************************************");
           
            Console.WriteLine("Объем цилиндра равен: " + ds.CylinderVolume(r, h));
            Console.ReadLine();
        }
    }
}
