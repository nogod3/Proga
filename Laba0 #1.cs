using System;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Введите коэффициент a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату x1:");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату y1:");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координату x2:");
        double x2 = Convert.ToDouble(Console.ReadLine());

        double b = y1 - a * x1;

        double y2 = a * x2 + b;

        Console.WriteLine("Ордината точки O2: " + y2);
    }
}
