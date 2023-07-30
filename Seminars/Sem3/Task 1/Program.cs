// Программа, которая принимает координаты 2-х точек и говорит в какой четверти они находятся

int FindQuad(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return 0;
}

System.Console.WriteLine("Input X coordinate");
int x = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Input Y coordinate");
int y = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine($"Point with X coordinate ({x}) and Y coodrinate ({y}) belongs to {FindQuad(x, y)} quart");