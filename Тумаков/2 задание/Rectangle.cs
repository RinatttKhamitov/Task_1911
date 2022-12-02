using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков._2_задание
{
    class Rectangle : Point
    {
        int a;
        int b;
        public Rectangle(string color, Condition condition, int[] coordinates, int a, int b) : base(color, condition, coordinates)
        {
            this.a = a;
            this.b = b;
        }
        public double AreaOfARectangle()
        {
            return a*b;
        }
    }
}
