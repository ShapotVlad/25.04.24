﻿// Задайте массив. Напишите программу,которая определяет,присутствует ли заданно ечисло в массиве.
//Программа должна выдатьответ:Да/Нет.
//Примеры [1 3 4 19 3], 8 => Нет
//[-4 3 4 1], 3 => Да


// int[] array1 = new int[5];
// int[] array2 = new int[5] { 3, 6, 8, 3, 9 };
// int[] array3 = new int[] { 3, 6, 8, 3, 9 };

int[] array = {1, 3, 8, 19, 3, 8};
int num = 8;

bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == num) 
    {
        isExistNum = true;
        break;
    }
}



//string result = isExistNum ? "Да" : "Нет";
Console.WriteLine(isExistNum ? "Да" : "Нет");