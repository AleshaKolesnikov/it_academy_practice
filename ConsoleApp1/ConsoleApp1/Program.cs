using System;
using FigureAreaTask.BasicClasses;
using FigureAreaTask.Figures;

namespace FigureAreaTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Figure[] figures = new Figure[5];

            figures[0] = new Square(random.Next(1, 10));
            figures[1] = new Circle(random.Next(1, 10));
            figures[2] = new Triangle(random.Next(1, 10));
            figures[3] = new Circle(random.Next(1, 10));
            figures[4] = new Triangle(random.Next(1, 10));

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine($"This is {figures[i].Name}, CLR Type is {figures[i]}, Area is {figures[i].Area()}");
            }
        }
    }
}