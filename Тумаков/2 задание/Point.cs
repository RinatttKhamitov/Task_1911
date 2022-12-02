using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков._2_задание
{
    class Point : Figure
    {
        public Point(string color, Condition condition, int[] coordinates)
        {
            this.color = color;
            this.condition = condition;
            this.coordinates = coordinates;
        }
        public override void InterviewCondition()
        {
            Console.WriteLine(condition);
        }


        public override void MovementHorizontal()
        {
            coordinates[0] += 1;
        }

        public override void MovementVertical()
        {
            coordinates[1] += 1;
        }
        public override void ChangeColor()
        {
            Console.WriteLine("Какой цвет?");
            color = Console.ReadLine();
        }
        public override void Print()
        {
            Console.WriteLine($"цвет - {color}");
            Console.WriteLine($"координты - x ({coordinates[0]}, y ({coordinates[1]})");
        }
    }
}
