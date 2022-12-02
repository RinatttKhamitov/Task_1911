using System;
using System.Collections.Generic;
using System.Text;

namespace Тумаков._2_задание
{
    enum Condition
    {
        видимое,
        невидимое
    }
    abstract class Figure
    {
        public string color;
        public Condition condition;
        public int[] coordinates;
        public abstract void MovementHorizontal();
        public abstract void MovementVertical();
        public abstract void ChangeColor();
        public abstract void InterviewCondition();
        public abstract void Print();


    }
}
