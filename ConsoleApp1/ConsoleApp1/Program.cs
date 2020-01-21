using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd1 = new Random();
            int lengthOrWidth = rnd1.Next(1, 10);
            Random rnd2 = new Random();
            int height = rnd1.Next(1, 10);

            Rectangle rectangle = new Rectangle(lengthOrWidth, height);
            Square square = new Square(lengthOrWidth);
            Circle circle = new Circle(lengthOrWidth);

            Figure[] array = new Figure[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] =
            }
        }
    }
    abstract class Figure
    {
        public abstract float Area();
    }
    class Rectangle : Figure
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override float Area()
        {
            return Width * Height / 2;
        }
    }
    class Square : Figure
    {
        public float Length { get; set; }
        public Square(float length)
        {
            this.Length = length;
        }
        public override float Area()
        {
            return Length * Length;
        }
    }
    class Circle : Figure
    {
        public float Radius { get; set; }
        public Circle(float radius)
        {
            this.Radius = radius;
        }
        public override float Area()
        {
            return Radius * Radius * 3.14F;
        }
    }
}
