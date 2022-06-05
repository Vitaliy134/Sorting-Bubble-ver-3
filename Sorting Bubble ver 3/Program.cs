using System;
using static System.Console;

namespace Sorting_Bubble_ver_3
{
    internal class Program
    {

        static public void Main()
        {
            int[] array = new int[100];                          // инициализируем массив 
            array = Random_Filling(array);                       // скармлеваем массиву рандом 
            Print(array);                                        // выводим массив с рандомом
            WriteLine("Массив с Рандомом подьехал");
            WriteLine("Press any key to continue");
            ReadKey();
            Clear();
            array = SortBubble(array);                           // сортируем массив Пузырьками
            Print(array);                                        // выводим массив c рандомом отсортированный пузырьками
            WriteLine("Массив с Рандомом отсортирован ПУЗЫРЬКАМИ");
            BackgroundColor = ConsoleColor.DarkRed;
            WriteLine("Press any key to EXIT");
            ReadKey();
        }

        static int[] Random_Filling(int[] x)
        {
            Random array_Filling = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = array_Filling.Next(-1000, 1000);
            }
            return x;
        }

        static int[] SortBubble(int[] y)
        {
            int cache;
            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < y.Length - 1 - i; j++)
                {
                    if (y[j] > y[j + 1])
                    {
                        cache = y[j];
                        y[j] = y[j + 1];
                        y[j + 1] = cache;
                    }
                }
            }
            return y;
        }

        static void Print(int[] h)
        {
            for (int i = 0; i < h.Length; i++)               
            {
                int position = i;
                WriteLine(position + 1 + "). " + h[i]);
            }
        }

    }
}
