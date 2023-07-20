using System;
namespace Guru
{
class Program
{
static void Main()
{
    System.Console.Write("Enter the radius: ");
    double radius = Convert.ToDouble(Console.ReadLine());
    const float pi = 3.14f;
    System.Console.WriteLine($"Space: {pi}*({radius}*{radius})="+ pi*radius*radius);
}
}
}