using System;

namespace Exercise2._2._3
{
    class Program
    { /*                                        ____________________Задание №2.2.3____________________
        Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная. */

        static void Main(string[] args)
        {
            
            static void Number(int[] mass)//Функция находит индекс минимального и максимального элемента

            {
                int box = 0, min = 0, max = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    

                    if (box < mass[i])// нахождение индекса максимального элемента
                    { box = mass[i];
                        max = i;
                    }

                    else if (box > mass[i])// нахождение индекса минимального элемента
                    {
                        box = mass[i];
                        min = i;
                    }
                }
                    if (min < max)// проверка какой элемент расположен левее 
                    { Console.Write(" Левее расположена минимальная цифра "); }     
                    else
                    { Console.Write(" Левее расположена минимальная цифра "); }
                
            }
            Console.Write("Введите число в котором все цифры различны: ");
            char[] CharMass= Console.ReadLine().ToCharArray();// Пользователь вводит число
            int[] Mass = new int[CharMass.Length];

            for (int i = 0; i < Mass.Length; i++)
            {
                 Mass[i] = (int)(CharMass[i] - '0');// Перобразуем тип char в int
            }
           
            Number(Mass);//Вызываем метод для рассчётов 
        }
    }
}
