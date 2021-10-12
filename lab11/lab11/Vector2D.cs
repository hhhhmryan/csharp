using System;
using System.Collections.Generic;
using System.Text;

namespace lab11
{
    class Vector2D
    {
        double x;
        double y;
        public Vector2D()
        {
            x = 0.0;
            y = 0.0;
        }

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2D add(Vector2D a)
        {
            Vector2D temp = new Vector2D();
            temp.x = a.x + this.x;
            temp.y = a.y + this.y;
            return temp;
        }

        public void add2(Vector2D a)
        {
            this.x = a.x + this.x;
            this.y = a.y + this.y;
        }

        public Vector2D sub(Vector2D a)
        {
            Vector2D temp1 = new Vector2D();
            temp1.x = a.x - this.x;
            temp1.y = a.y - this.y;
            return temp1;
        }

        public void sub2(Vector2D a)
        {
            this.x = a.x - this.x;
            this.y = a.y - this.y;
        }

        public Vector2D mult(double a)
        {
            Vector2D temp = new Vector2D();
            temp.x = this.x * a;
            temp.y = this.y * a;
            return temp;
        }

        public void mult2(double a)
        {
            this.x = this.x * a;
            this.y = this.y * a;
        }

        public String toString()
        {
            string x = $"({this.x},{this.y})";
            return x;
        }

        public double length()
        {
            double x = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            return x;
        }

        public double scalarProduct(Vector2D a)
        {
            double temp = this.x * a.x + this.y * a.y;
            return temp;
        }

        public double cos(Vector2D a)
        {
            double temp = (this.x * a.x + this.y * a.y) / (Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2)) * Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2)));
            return temp;
        }

        public bool equals(Vector2D a)
        {
            bool x = (this.x == a.x) && (this.y == a.y);
            return x;
        }


    }
}

