using System;

namespace Exercise3._1._4
{
    class Program
    {
        /*                                        ____________________Задание №3.1.4____________________
     Дана целочисленная прямоугольная матрица. Определить:сумму элементов в тех строках, которые содержат хотя бы один отрицательный элемент;
     номера строк и столбцов всех седловых точек матрицы.
     Примечание. Матрица А имеет седловую точку Аij, если Аij является минимальным элементом в i-й строке и максимальным в j-м столбце.

       */

        //Метод для вывода матрицы
        static void Output(int [,] array ,int row, int column)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                { Console.Write(array[i, j]+"\t" ); }
                Console.WriteLine();
            }
        }
        //Метод ищет негативне элементы в каждой строке, при нахождении вывводит суму элементов даной строки
        static void FindNegativeElement(int [,] array,int row, int column)
        {
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (array[i, j] < 0)//Проверка элемента
                    {
                        for (int x = 0; x < column; x++)
                        {
                            sum += array[i, x];//Суммирование элементов строки
                        }
                        Console.WriteLine($"В {i} строке обнаружен отрицательный элемент. Сума элементов равна : {sum}");
                        sum = 0;//Сброс суммы 
                        break;//Выход из внутеннего цикла

                    }
                }  
            }
        }
        //метод для поиска седловых точек матрицы
        static void FindPoints(int[,] array, int row, int column)
        {
            
            int min_index =0, max_index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0,min = int.MaxValue; j < column; j++)
                { 
                    if (min > array[i, j])//Поиск минимальный элемент в строке
                    {
                        min = array[i, j ];
                        min_index =  j;
                    }
                }
                for(int x = 0, max = int.MinValue; x < row ; x++)
                {
                    if (max < array[x, min_index])//Поиск максимальный элемента в столбце предпологаемой седловой точки
                    {
                        max = array[x, min_index];
                        max_index = x;
                    }
                }
                if (max_index == i)//Проверка условий седловой точки
                {
                    Console.WriteLine($"Найдена седловая точка матрицы {i} строка столбец {min_index}");//Вывод результатов
                }
                
            }
        }
        static void Main(string[] args)
        {   //Задаём размерность матрицы
            int row = 4, column = 3;
            //Задаём значения массива
            int[,] array = { 
                {25 , -65 , -1   },
                {62 , -2  ,  5   },
                {100, 101 , 150  },
                {105, 102 , 103} };
            
           
            Console.WriteLine("Заданная матрица:");
            //Вызывзов методов 
            Output(array,row,column);
            FindNegativeElement(array, row, column);
            FindPoints(array, row, column);
        }
       
    }
}
