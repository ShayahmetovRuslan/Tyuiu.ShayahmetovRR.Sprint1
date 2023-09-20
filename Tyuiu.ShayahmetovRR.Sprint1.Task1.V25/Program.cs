using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint1.Task1.V25.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шаяхметов Р. Р.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Организация ввода\вывода в консольных приложениях              *");
            Console.WriteLine("* Задание #1                                                           *");
            Console.WriteLine("* Вариант #25                                                          *");
            Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич  | АСОиУБ-23-1                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет выражение     *");
            Console.WriteLine("*                                     по формуле  (x*y)/(1+x)          *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: (5*2)/(1+5)                                         *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine(ds.Calculate(5.0, 2.0));
            Console.ReadLine();
        }
    }
}
