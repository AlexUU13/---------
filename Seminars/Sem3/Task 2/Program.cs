// Запишите программу, которая принимает координаты 2-х точек и находит расстояние межу ними в 2D пространстве



double Distans(double x1, double y1, double x2, double y2)
{

    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

}


System.Console.WriteLine("Input coordinate X1");
double x1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Input coordinate Y1");
double y1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Input coordinate X2");
double x2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Input coordinate Y2");
double y2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Distanse between ({x1}, {y1}) and ({x2}, {y2}) is {Distans(x1, y1, x2, y2)}");