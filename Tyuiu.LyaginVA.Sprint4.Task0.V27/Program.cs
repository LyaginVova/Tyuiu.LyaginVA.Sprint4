using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LyaginVA.Sprint4.Task0.V27.Lib;

namespace Tyuiu.LyaginVA.Sprint4.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Лягин В. Л. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Лягин Владимир Александрович | АСОиУБ-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9  подсчитать произведение  *");
            Console.WriteLine("* нечетных элементов массива. {7 ,4 ,3 ,2 ,1 ,5 ,9 ,8 ,7 ,4}              *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходный массив:");
            int[] array = new int[] { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение нечётных элементов массива: {ds.GetMultOddArrEl(array)}");
            Console.ReadKey();
        }
    }
}
