using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Определить, имеется ли в массиве случайных чисел элемент, значение которого равно значению первого элемента одномерного массива.
            //Если такой элемент имеется, вывести на экран его порядковый номер. Массив состоит из шести элементов.

            //int[] mas = new int[6];
            //Random rnd = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rnd.Next(0, 10);
            //    if (mas[i] == mas[1])
            //    {
            //        Console.WriteLine(i); 
            //    }
            //}

            //Задача 2. Дан одномерный массив. Вывести:
            //а) все неотрицательные элементы;
            //б) все элементы, не превышающие число 100;
            //в) все четные элементы.

            //int[] mas = new int[30];
            //Random rnd = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = rnd.Next(-200, 200);
            //}
            //Console.WriteLine("все неотрицательные элементы");
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] >= 0)
            //    {
            //        Console.WriteLine(mas[i]);
            //    }
            //}
            //Console.WriteLine("все элементы, не превышающие число 100");
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] < 100)
            //    {
            //        Console.WriteLine(mas[i]);
            //    }
            //}
            //Console.WriteLine("все четные элементы");
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] % 2 == 0)
            //    {
            //        Console.WriteLine(mas[i]);
            //    }
            //}


            //Задача 3. Заполнить одномерный массив без использования клавиатуры следующими значениями:
            //5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2. Подсчитать количество отрицательных элементов.

            //int[] mas = { 5, -3, 4, -8, -9, 1, 9, 6, -3, 4, 8, 2 };
            //int a = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    if (mas[i] < 0)
            //    {
            //        a++;
            //    }
            //}
            //Console.WriteLine(a);

            //Задача 4. Составьте программу вычисления среднего арифметического элементов с нечетными номерами.

            //int[] mas = new int[10];
            //int a = 0;
            //int b = 0;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = int.Parse(Console.ReadLine());
            //    if (i % 2 == 1)
            //    {
            //        a += mas[i];
            //        b++;
            //    }
            //}
            //a /= b;
            //Console.WriteLine(a);

            //Задача 5. Составьте программу увеличения всех элементов массива в 5 раз.

            int[] mas = new int[10];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
                mas[i] *= 5;
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }


            Console.ReadKey();
        }
    }
}
