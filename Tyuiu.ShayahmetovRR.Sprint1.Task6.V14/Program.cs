using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint1.Task6.V14.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint1.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Шаяхметов Р. Р.  | АСОиУБ-23-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #1                                                            *");
            Console.WriteLine("* Тема: Работа со строками класс String                                *");
            Console.WriteLine("* Задание #6                                                           *");
            Console.WriteLine("* Вариант #14                                                          *");
            Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич  | АСОиУБ-23-1                   *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("*Написать программу, которая проверяет наличие строчных русских букв   *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            string pass;
            Console.WriteLine("Введите строку: ");
            pass = Console.ReadLine();
            Console.WriteLine("************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("************************************************************************");
            if (ds.CheckLowerCaseRusLetters(pass) == true)
            {
                Console.WriteLine("Success");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
        }   
    }
}