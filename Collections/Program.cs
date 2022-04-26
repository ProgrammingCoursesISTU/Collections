using System;
using System.Collections.Generic; //Нужно для использования List

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Массив
            var array = new int[10]; //Создание массива
            array[0] = 12;  //Изменение элементов массива
            array[9] = 5;
            array[5] = 8;
            int arrayItemsCount = array.Length; //Длина массива

            //Список
            var list = new List<int>(); //Создание списка
            list.Add(15); //Добавить элемент в список
            list.RemoveAt(0); //Удалить элемент по индексу
            list.Remove(15); //Удалить первый элемент, равный тому, что в скобках
            int listItemsCount = list.Count; //Длина списка

            //Цикл, позволяющий перебрать все элементы коллекции
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //Задача_1
            //1.Дан одномерный массив целых чисел из 30 элементов.
            //Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)
            //Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.
            //Программа должна работать с массивом любого размера.
            //Массив всех локальных максимумов не нужен.

            list.Clear();
            var random = new Random(); //Создание генератора случайных чисел
            for (int i = 0; i < 30; i++)
            {
                list.Add(random.Next(0, 101));//Добавить случайный элемент в список
                Console.Write($"{list[i]} ");
            }

            for (int i = 1; i < list.Count - 1; i++)
            {
                if (list[i] > list[i - 1] && list[i] > list[i + 1])
                    Console.WriteLine(list[i]);
            }

            if (list[0] > list[1])
                Console.WriteLine(list[0]);

            if (list[list.Count - 1] > list[list.Count - 2])
                Console.WriteLine(list[list.Count - 1]);

            list.Clear();
            Console.WriteLine();
            //Задача_2
            //2.В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
            //Дано 30 чисел.Вывести в консоль сам массив, число, которое само больше раз повторяется подряд и количество повторений.
            //Дополнительный массив не надо создавать.
            //Пример: { 5, 5, 9, 9, 9, 5, 5}
            //-число 9 повторяется большее число раз подряд.

            for (int i = 0; i < 30; i++)
            {
                list.Add(random.Next(0, 3));//Добавить случайный элемент в список
                Console.Write($"{list[i]} ");
            }

            int currentRepeated = 1;
            int maxRepeated = 0;
            int maxRepeatedValue = 0;

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                    ++currentRepeated;
                else
                    currentRepeated = 1;

                if (currentRepeated > maxRepeated)
                {
                    maxRepeated = currentRepeated;
                    maxRepeatedValue = list[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{maxRepeated}, {maxRepeatedValue}");

            Console.WriteLine();
            //Задача_3
            //3.Дана строка с текстом, используя метод строки String.Split() получить массив слов, которые разделены пробелом в тексте 
            //и вывести массив, каждое слово с новой строки.

            string example = "Try parse me. You ain't have a chance.";
            char[] separators = new char[] { ' ', '.' };

            var splitedString = example.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var str in splitedString)
            {
                Console.WriteLine(str);
            }

            //Задачу 4 решить обязательно, 5 или 6 на выбор

            //4.Дан массив чисел(минимум 10 чисел). Надо вывести в консоль числа отсортированы, от меньшего до большего.
            //Нельзя использовать Array.Sort.Можно найти подходящий алгоритм сортировки и использовать его для задачи.

            //5.Дан массив чисел. Нужно его сдвинуть циклически на указанное пользователем значение позиций влево, не используя других массивов.Пример для сдвига один раз: { 1, 2, 3, 4} => { 2, 3, 4, 1}

            //6.Пользователь вводит числа, и программа их запоминает.
            //Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.
            //Выход из программы должен происходить только в том случае, если пользователь введет команду exit.
            //Если введено не sum и не exit, значит это число и его надо добавить в массив.
            //Программа должна работать на основе расширения массива.
        }
    }
}
