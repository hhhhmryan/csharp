using System;
using System.Collections.Generic;
using System.Text;

namespace lab13task2
{
    class Hyperbola : Function
    {

        double a;
        double b;

        public Hyperbola(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Func(double x)
        {
            return a / x + b;
        }

        public override void Info()
        {
            Console.WriteLine("Ваша функция: Гипербола.");
            Console.WriteLine($"Коэфициенты функции. a = {a}, b = {b}");
        }
    }
}
