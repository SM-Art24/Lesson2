using System;

namespace Exercise_2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*                                                    ____________________Задание №2.2.2____________________
                                          Дано натуральное число. Определить, верно ли, что сумма его цифр больше m, а само число заканчивается на y?*/


            
           
          
            //Проверка суммы цифр
            static bool Check_M(int number, int m)
            {
                int sum = 0;
                bool check_m = false; ;

                while (number != 0)
                {  sum += number % 10;//Перебор цифр
                   unchecked { number /= 10; }
                }

                if (sum > m)
                { check_m = true; }

                return check_m;
            }
            //Проверка конца числа
            static bool Check_Y(int number,  int y)
            {
                bool check_y = false;
                if (number % 10 == y)
                {check_y = true;}
                return check_y;
            }

            //Начальные параметры
            Console.WriteLine("Введите начальные параметры");
            Console.Write("Number = ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());
            //Вывод результатов
            if (Check_M(number, m) && Check_Y(number, y))
            {
                Console.WriteLine("Сума цифр больше " + m + " и число заканчивается на " + y);
            }
            else
            {
                Console.WriteLine("Условия не выполнены");
            }
           



        }
    }
}
