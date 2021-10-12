using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    class RationalVector2D
    {

        RationalFraction x;
        RationalFraction y;

        public RationalVector2D()
        {
            x = new RationalFraction();
            y = new RationalFraction();
        }

        public RationalVector2D(RationalFraction x, RationalFraction y)
        {
            this.x = x;
            this.y = y;
        }

        public RationalVector2D add(RationalVector2D a)
        {
            return new RationalVector2D(this.x.add(a.x), this.y.add(a.y));
        }

        public string toString()
        {
            string x = $"({this.x.toString()},{this.y.toString()})";
            return x;
        }

        public double length()
        {
            RationalFraction a = new RationalFraction();
            RationalFraction b = new RationalFraction();
            RationalFraction c = new RationalFraction();
            a = this.x.mult(this.x);
            b = this.y.mult(this.y);
            c = a.add(b);
            double x = Math.Sqrt(c.value());
            return x;
        }

        public RationalFraction scalarProduct(RationalVector2D a)
        {
            RationalFraction temp = this.x.mult(a.x).add(this.y.mult(a.y));
            return temp;
        }


        public bool equals(RationalVector2D a)
        {
            bool x = (this.x.equals(a.x) && (this.y.equals(a.y)));
            return x;
        }





    }
}
