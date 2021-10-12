using System;
using System.Collections.Generic;
using System.Text;

namespace lab13task2
{
    class Line : Function
    {

        double k;
        double b;

        public Line(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public override double Func(double x)
        {
            return k * x + b;
        }

        public override void Info()
        {
            Console.WriteLine("Ваша функция: Прямая.");
            Console.WriteLine($"Коэфициенты функции. k = {k}, b = {b}");
        }

    }
}
