﻿// задать одномерный массив из 10 целых чисел
//от 1 до 100. Найти количество  элементов диапозоне [10,90]   


int[] array = new int[10] { 13, 4, 25, 6, 8, 34, 7, 9, 51, 73 };

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>10 && array[i]<90)
    {
        count = count + 1;
    }
}

 Console.WriteLine($"количество элементов в диапозоне от 10 до 90 = {count}");

// {
//         int cnt = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] >= minRange && numbers[i] <= maxRange)
//             {
//                 cnt++;
//             }
//         }
//         return cnt;
//     }

//     public static void PrintResult(int[] array)
//     {

//         Console.WriteLine(CountItemsRange(array, 10, 90));
//     }


