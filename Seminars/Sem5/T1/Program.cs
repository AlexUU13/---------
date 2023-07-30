// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] CreateNewArray(int size, int minValue, int maxValuse)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValuse + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     System.Console.Write(array[int] + ' ');
// }
// System.Console.WriteLine();


int[] CreateNewArray(int size, int minValue, int maxValuse)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValuse + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int positive = 0;
    int negative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            positive = positive + array[i];
        }
        else
        {
            negative = negative + array[i];
        }

    }
    System.Console.WriteLine($"Summ of the Positive element of Array is -> {positive}");
    System.Console.WriteLine($"Summ of the Negative element of Array is -> {negative}");
    System.Console.WriteLine();
}

System.Console.WriteLine("Enter array lens");
int size = Convert.ToInt32(Console.ReadLine());
int minValue = -9;
int maxValuse = 9;

PrintArray(CreateNewArray(size, minValue, maxValuse));

