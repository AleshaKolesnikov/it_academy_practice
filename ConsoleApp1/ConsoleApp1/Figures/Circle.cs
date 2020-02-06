using System;
using System.Collections.Generic;
using System.Text;
using FigureAreaTask.BasicClasses;

namespace FigureAreaTask.Figures
{
    class Circle : Figure
    {
        public Circle(float side)
        {
            Name = "Circle";
            Side = side;
        }
        public override float Area()
        {
            return Side * Side * (float)Math.PI;
        }
    }
}
