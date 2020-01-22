using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaTask.BasicClasses
{
    abstract class Figure
    {
        public string Name { get; set; }
        public float Side { get; set; }

        public abstract float Area();
    }
}
