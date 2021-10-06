using System;

namespace Exercise_2._2._1
{
    class Program
    {
        /*                                       ____________________Задание №2.2.1____________________
                                          Дано натуральное число. Верно ли, что цифра а встречается в нем более k раз?*/

        static void Main(string[] args)
        {
            //Проверка числа
            static int CheckNumeral(int a, long number)
            {
                int result = 0;
                while (number != 0)
                {
                    if (number % 10 == a) //Перебор цифр
                        result++;
                    unchecked { number /= 10; }
                }
                return result;
            }

            Random rand = new Random();
            //Начальные параметры
            Console.WriteLine("Введите число : ");
            long number = Convert.ToInt32(Console.ReadLine());// Пользователь вводит число
            int a = rand.Next(9);

            Console.WriteLine("Число k :");// Пользователь вводит число
            int k = Convert.ToInt32(Console.ReadLine());

            //Проверка и вывод результатов 
            if (CheckNumeral(a, number) > k)
            {
                Console.WriteLine("Цифра " + a + " встречается более " + k + " раз");
            }
            else
            {
                Console.WriteLine("Цифра  " + a + " не встречается более " + k + " раз");
            }

        }
    }
}
