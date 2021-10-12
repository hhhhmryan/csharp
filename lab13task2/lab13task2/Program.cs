using System;

namespace lab13task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Function[] functions = new Function[4];
            functions[0] = new Line(2, 4);
            functions[1] = new Cube(2, 5, 6);
            functions[2] = new Hyperbola(3, 2);
            functions[3] = new Line(4, 5);

            for (int i = 0; i < functions.Length; i++)
            {
                functions[i].Info();
                Console.WriteLine("Значение функции в точке x = 5 равно: " + functions[i].Func(5));
                Console.WriteLine();
            }
        }
    }
}
