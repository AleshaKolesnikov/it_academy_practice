using System;
using System.Collections.Generic;
using System.Text;
using FigureAreaTask.BasicClasses;

namespace FigureAreaTask.Figures
{
    class Triangle : Figure
    {
        public Triangle(float side)
        {
            Name = "Triangle";
            Side = side;
        }
        public override float Area()
        {
            return 0.433f * Side * Side;
        }
    }
}
