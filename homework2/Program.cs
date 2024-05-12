//задать массив  из 10 целых чисел
//определить  коичество четных чисел в массиве

int[] array = new int[10] { 13, 4, 25, 6, 8, 34, 78, 9, 52, 73 };

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count = count + 1;
    }
}

 Console.WriteLine($"количество четных элементов в массиве = {count}");


// // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         int cnt = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//             {
//                 cnt++;
//             }
//         }
//         return cnt;
//     }

//     public static void PrintResult(int[] array)
//     {
//         Console.WriteLine(CountEvenItems(array));
//     }