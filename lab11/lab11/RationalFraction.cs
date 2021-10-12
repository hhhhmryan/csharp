using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    class RationalFraction
    {
        int x;
        int y;

        public RationalFraction()
        {
            x = 0;
            y = 0;
        }

        public RationalFraction(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void reduce()
        {
            int c;
            if (this.x < this.y)
            {
                c = this.x;
            }
            else
            {
                c = this.y;
            }
            for (int i = 1; i <= c; i++)
            {
                if (this.x % i == 0 && this.y % i == 0)
                {
                    this.x = this.x / i;
                    this.y = this.y / i;
                }
            }

        }

        public RationalFraction add(RationalFraction a)
        {
            RationalFraction temp = new RationalFraction();
            temp.x = this.x * a.y + a.x * this.y;
            temp.y = this.y * a.y;
            temp.reduce();
            return temp;
        }

        public void add2(RationalFraction a)
        {
            this.x = this.x * a.y + a.x * this.y;
            this.y = this.y * a.y;

            RationalFraction temp = new RationalFraction();
            temp.x = this.x;
            temp.y = this.y;
            temp.reduce();
            this.x = temp.x;
            this.y = temp.y;
        }

        public RationalFraction sub(RationalFraction a)
        {
            RationalFraction temp = new RationalFraction();
            temp.x = this.x * a.y - a.x * this.y;
            temp.y = this.y * a.y;
            temp.reduce();
            return temp;
        }

        public void sub2(RationalFraction a)
        {
            this.x = this.x * a.y - a.x * this.y;
            this.y = this.y * a.y;
            RationalFraction temp = new RationalFraction();
            temp.x = this.x;
            temp.y = this.y;
            temp.reduce();
            this.x = temp.x;
            this.y = temp.y;
        }

        public RationalFraction mult(RationalFraction a)
        {
            RationalFraction temp = new RationalFraction();
            temp.x = this.x * a.x;
            temp.y = this.y * a.y;
            temp.reduce();
            return temp;
        }

        public void mult2(RationalFraction a)
        {
            this.x = this.x * a.x;
            this.y = this.y * a.y;
            RationalFraction temp = new RationalFraction();
            temp.x = this.x;
            temp.y = this.y;
            temp.reduce();
            this.x = temp.x;
            this.y = temp.y;
        }

        public RationalFraction div(RationalFraction a)
        {
            RationalFraction temp = new RationalFraction();
            temp.x = this.x * a.y;
            temp.y = this.y * a.x;
            temp.reduce();
            return temp;
        }

        public void div2(RationalFraction a)
        {
            this.x = this.x * a.y;
            this.y = this.y * a.x;
            RationalFraction temp = new RationalFraction();
            temp.x = this.x;
            temp.y = this.y;
            temp.reduce();
            this.x = temp.x;
            this.y = temp.y;
        }

        public String toString()
        {
            string x = $"{this.x}/{this.y}";
            return x;
        }

        public double value()
        {
            double a = this.x;
            double b = this.y;
            double x = a / b;
            return x;
        }

        public bool equals(RationalFraction a)
        {
            RationalFraction temp = new RationalFraction();
            temp.x = this.x;
            temp.y = this.y;

            temp.reduce();
            a.reduce();

            bool x = (temp.x == a.x) && (temp.y == a.y);
            return x;
        }

        public int numberPart()
        {
            int a = this.x;
            int b = this.y;
            int part = a / b;
            return part;
        }



    }
}
