using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint1.Task7.V30.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шаяхметов Р. Р.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
            Console.WriteLine("* Задание #7                                                           *");
            Console.WriteLine("* Вариант #30                                                          *");
            Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич  | АСОиУБ-23-1                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*Написать программу, которая вычисляет результат по формуле            *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            double x, y, z;
            Console.WriteLine("Введите x: ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            y = Convert.ToInt16(Console.ReadLine());
            z = ds.Calculate(x, y);
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
