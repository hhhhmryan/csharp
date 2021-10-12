using System;

namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[3];
            figures[0] = new Circle(8);
            figures[1] = new Rectangle(5, 8);
            figures[2] = new Triangle(3, 4, 5);


            for (int i = 0; i < figures.Length; i++)
            {
                figures[i].Info();
                double p = figures[i].Perimeter();
                double s = figures[i].Square();
                Console.WriteLine("Периметр фигуры: " + p);
                Console.WriteLine("Площадь фигуры: " + s);
            }

        }
    }
}
