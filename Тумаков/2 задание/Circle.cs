using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков._2_задание
{
    class Circle : Point
    {
        int radius;

        public Circle(string color, Condition condition, int[] coordinates, int radius) : base(color, condition, coordinates) 
        {
            this.radius = radius;
        }
        public double AreaOfACircle()
        {
            return Math.PI * radius * radius;
        }


    }
}
