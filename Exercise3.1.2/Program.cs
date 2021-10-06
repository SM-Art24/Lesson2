using System;

namespace Exercise3._1._2
{
    class Program
    {
        /*                                        ____________________Задание №3.1.2____________________
       Даны два возрастающих целочисленных массива: x длиной k и y длиной m. Найти количество общих элементов в этих массивах
       (то есть количество тех целых t, для которых t=x[i]=y[j] для некоторых i и j)*/
       
        static void Output(int[] mass) //Вывод массива 
        { 
            foreach (int i in mass)
            {
                Console.Write(i + "\t");
            }
        }
        static int CompareArray(int[] array_1, int[] array_2) // Метод сравнивает два массива и возвращает количество общих элементов 
        {
            int GeneralElement = 0;//Количество общих элементов
            
            for(int i =0;i<array_1.Length;i++)
            {
                for (int j = 0; j< array_2.Length;j++)
                {
                    if (array_1[i]==array_2[j])//Сравнение каждого элемента массива
                    {
                        GeneralElement++;
                    }
                }
            }
            return GeneralElement;//Возвращаем общее количество
        }

        static void Main(string[] args)
        {
            int[] array_1 = new int[5] { 2, 4, 5, 20, 26 };//Задаём первый массив 
            int[] array_2 = new int[9] { 3, 9, 10, 20, 26, 3, 55, 68, 89 };//Задаём второй массив 

            Console.Write("Первый массив : ");
            Output(array_1);
            Console.Write("\nВторой массив : ");
            Output(array_2);
            Console.WriteLine("\nКоличество общих элементов : " + CompareArray(array_1,array_2));//Вывод результатов

        }

    }
}
