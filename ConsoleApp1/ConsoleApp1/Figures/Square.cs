using System;
using System.Collections.Generic;
using System.Text;
using FigureAreaTask.BasicClasses;

namespace FigureAreaTask.Figures
{
    class Square : Figure
    {
        public Square(float side)
        {
            Name = "Square";
            Side = side;
        }
        public override float Area()
        {
            return Side * Side;
        }
    }
}
