using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LyaginVA.Sprint4.Task3.V29.Lib;

namespace Tyuiu.LyaginVA.Sprint4.Task3.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas2 = new int[5, 5] { { 9, 9, 8, 6, 9 },
                                          { 5, 8, 8, 8, 7 },
                                          { 6, 5, 9, 7, 9 },
                                          { 7, 7, 9, 7, 8 },
                                          { 8, 5, 8, 5, 5 } };

            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;


            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Лягин В. Л. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Лягин Владимир Александрович | АСОиУБ-23-2                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 5 до 9. Найдите произведение     *");
            Console.WriteLine("* элементов в первом столбце массива.                                     *");
            Console.WriteLine("*                                                                         *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }


                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mas2);

            Console.WriteLine("Произведение элементов в первом столбце массива = " + res);
            Console.ReadKey();
        }
    }
}
