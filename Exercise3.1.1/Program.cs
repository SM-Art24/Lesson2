using System;

namespace Exercise3._1._1
{
    class Program
    {
        /*                                        ____________________Задание №3.1.1____________________
        Найти расположение (индекс) наибольшего числа в массиве. Если таких чисел несколько, найти индекс первого из них.*/

        static void Output(int[] mass) //Вывод массива 
        {
            Console.Write("Заданый массив : ");
            foreach (int i in mass)
            {
                Console.Write(i + "\t");
            }
        }

        //Нахождение индекса наибольшего элемента в массиве 
        static int MaxNumverIndex  (int[] array)
        {
            int MaxNumber = 0;
            int MaxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {if (array[i] > MaxNumber) //Проверяем текущее число
                {
                    MaxNumber = array[i];
                    MaxIndex = i;
                }
            }           
            return MaxIndex;//Возвращаем индекс наибольшего числа
        }

    static void Main(string[] args)
        {
            int[] array = new int[10];//Создаём массив
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(50);//Заполняем массив случайными значениями 
            }
            Output(array);// Вызываем метод для вывода массива
            //Вызываем метод для нахождения индекса и выводим результат 
            Console.WriteLine("\nИндекс наибольшого элемента в массиве : " + MaxNumverIndex(array));
        }
    }
}






