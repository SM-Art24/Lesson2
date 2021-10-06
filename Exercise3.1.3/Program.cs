using System;

namespace Exercise3._1._3
{                                     
    class Program
    {
        /*                                        ____________________Задание №3.1.3____________________
      Даны заданное слово и непустая последовательность слов (одномерный символьный массив): между словами запятые или пробелы, в конце точка.
      В словах могут встретиться ошибки – переставлены две соседние буквы, заменена одна буква, пропущена одна буква. Требуется найти в 
      последовательности слов все слова, из которых могло бы получиться заданное слово в результате одной ошибки. Не использовать строковые функции
        */
       
        //Выделяет одно слово из строки слов и отправляет его на проверку 
        static void FindWord(string text, int index, string word)
        {

            string check_word = null;//Строка для хренения выделенного слова
            while (index < text.Length)//Проверка всей строки
            {
                while (text[index] != ' ' && text[index] != ','&& text[index] != '.')//Выделяем слово
                {
                    check_word += text[index];
                    index++;
                }
                CheckWord(word, ref check_word);//Вызываем метод для проверки слова
                index++;

            }
            

        }
        //Метод проверяет наличие и количество разных ошибок
        static void CheckWord(string word, ref string check_word)
        {
            int mistakes = 0;

            for (int i = 0,j=0; i < word.Length && j < check_word.Length; i++,j++)//Перебор каждого символа двух слов 
            {
                if (check_word[j] == word[i])//Проверяем символы
                    continue;
                else if (i + 1 == word.Length)//Проверка последний ли символ
                    mistakes++;
                else if (check_word[j] == word[i + 1] && check_word[j + 1] == word[i])//Проверка на переставленные соседние буквы
                {
                    mistakes++;
                    i++;
                    j++;
                }
                else if (check_word[j] == word[i + 1])//Проверка на неправильную букву
                {
                    mistakes++;
                    i++;
                }
                else if (check_word[j] != word[i])//Проверка на неправильную букву
                    mistakes++;  
            }
            if (mistakes <= 1)
            {
                Console.WriteLine("Слово " + check_word+"удовлетворяет заданные условия");
                
                check_word = null;//Удаляем текущее слово
            }
            else {
                check_word = null;//Удаляем текущее слово
            }
            
        }

        static void Main(string[] args)
        {

            Console.Write("Введите слово для проверки : ");
            string word = Console.ReadLine();
            Console.Write("Введите текст для проверки : ");
            string text = Console.ReadLine();
            
            int index = 0;//Хранит позицию проверки строки

            FindWord(text, index, word);//Выделение и проверка слов



        }



    }


}
