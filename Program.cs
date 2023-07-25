using System;
namespace Guru
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Choose the shape");
            System.Console.WriteLine("1.Circle");
            System.Console.WriteLine("2.Triangle");
            System.Console.WriteLine("3.1Rhombus");

            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    {
                        System.Console.Write("Enter the radius: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        const float pi = 3.14f;
                        System.Console.WriteLine($"Space: {pi}*({radius}*{radius})=" + pi * radius * radius);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the height and side of the triangle");
                        Console.Write("Height:");
                        double heightOfTriangle = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Side:");
                        double sideOfTriangle = Convert.ToDouble(Console.ReadLine());
                        
                        double areaOfTriagle = sideOfTriangle * heightOfTriangle/2;
                        Console.WriteLine($"Area of a triangle : {sideOfTriangle}*{heightOfTriangle}/2="+areaOfTriagle);
                        break;
                    }
            }

        }
    }
}