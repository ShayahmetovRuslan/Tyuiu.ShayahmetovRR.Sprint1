using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шаяхметов Р. Р.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                           *");
            Console.WriteLine("* Задание #5                                                           *");
            Console.WriteLine("* Вариант #7                                                           *");
            Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич  | АСОиУБ-23-1                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*Написать программу, которая определяет количество часов в зависимости *");
            Console.WriteLine("*                          от угла, на который повернута стрелка часов *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            double f, h;
            Console.WriteLine("Введите значение градуса отклонения от 0 до 360: ");
            f = Convert.ToInt16(Console.ReadLine());
            h = ds.AngleToHoursMinutes(f);
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("************************************************************************");

            if (f > 0 && f < 360)
            {
                Console.WriteLine($"Количество часов: {h} ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error. Введите значение от 0 до 360.");
                Console.ReadKey();
            }    
        }
    }
}
