using System;

namespace Exercise_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                                       ____________________Задание №1.1____________________
             Написать программу, которая в цикле введет 5 значений и посчитает произведение чисел, которые делятся без остатка на 3 и не делятся без остатка на 5.*/

            int result = 1;
            Random rand = new Random();
            int[] mass = new int[5];

            for (int i = 0; i < 5; i++)
            {
                mass[i] = rand.Next(30);//Заполняем массив рандомными числами
                Console.WriteLine("Значение элемента массива " + i + " = " + mass[i]);
               // Проверяем условия задачи 
                if (mass[i] % 3 == 0 && mass[i] % 5 != 0)
                {
                    result *= mass[i];
                }
            }
            Console.WriteLine("Результат :" + result); // Выводим результат

        }
    }
}
