//создать массив  из вещественных чисел с ненулевой дробной частью
//найти разницу между максимальноым и минимальным элементами массива

double[] array = new double[8] { 13.12, 4.22, 25.36, 34.78, 98.94, 9.69, 52.31, 73.63 };

double max = array[0];
double min = array[0];

double difference = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}

difference = max - min;

Console.WriteLine($"вывод результата = {difference}");


