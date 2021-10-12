using System;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//task1
            Vector2D a = new Vector2D(3, 4);
            Vector2D b = new Vector2D(1, 5);

            Vector2D c = b.add(a);
            b.add2(a);

            Vector2D d = b.sub(a);
            b.sub2(a);

            Vector2D f = b.mult(2);
            b.mult2(2);

            Console.WriteLine("a=" + a.toString());
            Console.WriteLine("b=" + b.toString());

            double x = a.length();

            double s = b.scalarProduct(a);

            double cos = b.cos(a);

            Console.WriteLine(b.equals(a));


            //task2
            RationalFraction a1 = new RationalFraction(2, 4);
            RationalFraction b1 = new RationalFraction(3, 5);

            a1.reduce();
            Console.WriteLine("a=" + a1.toString());

            RationalFraction m = b1.add(a1);
            b1.add2(a1);

            RationalFraction n = b1.sub(a1);
            b1.sub2(a1);

            RationalFraction k = b1.mult(a1);
            b1.mult2(a1);

            RationalFraction p = b1.div(a1);
            b1.div2(a1);

            Console.WriteLine("a=" + a1.toString());
            Console.WriteLine("b=" + b1.toString());

            double vala = a1.value();
            Console.WriteLine("Десятичое значение a == " + vala);

            Console.WriteLine(b1.equals(a1));

            int z = b1.numberPart();
            Console.WriteLine("Целая часть дроби: " + z);
            */

            // Lab12 Task1 
            RationalFraction a1 = new RationalFraction(2, 4);
            RationalFraction b1 = new RationalFraction(3, 5);
            RationalFraction c1 = new RationalFraction(1, 8);
            RationalFraction d1 = new RationalFraction(3, 2);
            RationalFraction a2 = new RationalFraction();
            RationalFraction b2 = new RationalFraction();

            RationalVector2D x = new RationalVector2D(a1, b1);
            RationalVector2D y = new RationalVector2D(c1, d1);
            RationalVector2D x2 = new RationalVector2D(a2, b2); // пустой вектор

            Console.WriteLine("Your vector 1:" + x.toString());
            Console.WriteLine("Your vector 2:" + y.toString());
            RationalVector2D sum = x.add(y);
            Console.WriteLine("Your summ:" + sum.toString());

            double len = x.length();
            Console.WriteLine("{0}{1:f3}", "Vector Length: ", len);

            RationalFraction mult = x.scalarProduct(y);
            Console.WriteLine("Scalar product of vectors: " + mult.toString());

            Console.WriteLine(x.equals(y));

























        }
    }
}
