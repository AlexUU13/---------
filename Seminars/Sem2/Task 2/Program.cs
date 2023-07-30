// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 7 и 23


void FindEven(int num1)
{
    if (num1 % 7 == 0 & num1 % 23 == 0)
    {
        Console.WriteLine($"Число {num1} кратно 7 и 23");
    }
    else
    {
        if (num1 % 7 == 0)
        {
            Console.WriteLine($"Число {num1} кратно 7 и не кратно 23");
        }
        else
        {
            if (num1 % 23 == 0)
            {
                Console.WriteLine($"Число {num1} кратно 23 и не кратно 7");
            }
            else
            {
                Console.WriteLine($"Число {num1} не кратно 7 и 23");
            }
        }
    }
}

System.Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

FindEven(a);
