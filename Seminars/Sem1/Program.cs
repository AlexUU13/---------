// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Квадат числа {num} -> {num*num}");

// Task2 Является ли число квадратом второго

// System.Console.WriteLine("Введите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine("Введите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 == num2*num2)
// {
//     Console.WriteLine($"Число {num1} ЯВЛЯЕТСЯ квадратом для числа {num2}");

// }
// else
// {
//     Console.WriteLine($"Число {num1} НЕ является квадратом для числа {num2}");
// }

// Task3 Написать программу, которая выводит числа от -N до N

// System.Console.WriteLine("Введите число, ряд которого вы хотите получить");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = -N;

// while (i <= N)
// {
//     Console.Write($"{i}, ");
//     i++;
// }


// Task 4. Ползователь вводт число. НАм требуется найти последюю цифру числа

System.Console.WriteLine("Введите 3-х значное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    num = num % 100;
    num = num % 10;
    Console.WriteLine($"Последняя цифра {num}");
}
else
{
    Console.WriteLine("Вы ввели не 3-х значное число");
}