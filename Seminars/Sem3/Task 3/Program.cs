void FindPow(double x)
{
    double i = 1;
    while (i <= x)
    {
        System.Console.WriteLine($"{i} -> {Math.Pow(i, 2)}");
        i++;
    }
}

System.Console.WriteLine("input number");
double x = Convert.ToDouble(Console.ReadLine());

FindPow(x);