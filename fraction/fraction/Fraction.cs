using System;
using System.Collections.Generic;
using System.Text;

namespace fraction
{
    class Fraction : IComparable
    {
        int sign;                   //   знак дроби (+ или -)
        int intPart;                //   целая часть дроби
        int numerator;              //   числитель дроби
        int denominator;            //   знаменатель дроби

        // метод преобразования дроби в смешанный вид
        void GetMixedView()
        {
            GetIntPart();        // выделение целой части числа
            Cancellation();      // сокращение дроби
        }

        // метод сокращения дроби
        void Cancellation()
        {
            if (numerator != 0)
            {
                int m = denominator,
                    n = numerator,
                    ost = m % n;
                // вычисление НОД(числителя, знаменателя)
                // алгоритмом Евклида
                while (ost != 0)
                {
                    m = n;
                    n = ost;
                    ost = m % n;
                }
                int nod = n;
                if (nod != 1)
                {
                    numerator /= nod;
                    denominator /= nod;
                }
            }
        }

        // метод выделения целой части дроби
        void GetIntPart()
        {
            if (numerator >= denominator)
            {
                intPart += (numerator / denominator);
                numerator %= denominator;
            }
        }

        // конструктор без параметров
        public Fraction()
        {
            intPart = 0;
            numerator = 0;
            denominator = 1;
            sign = 1;
        }

        // конструктор c параметрами
        public Fraction(int n, int d, int i = 0, int s = 1)
        {
            intPart = i;
            numerator = n;
            denominator = d;
            sign = s;
            GetMixedView();
        }

        // деструктор
        ~Fraction()
        {
            Console.WriteLine("Дробь " + this + " уничтожена.");
        }

        // операция преобразования дроби в тип double
        public static explicit operator double(Fraction ob)
        {
            double res = (double)ob.sign * (ob.intPart * ob.denominator +
                                  ob.numerator) / ob.denominator;
            return res;
        }

        // метод сложения двух дробей
        static public Fraction operator +(Fraction ob1, Fraction ob2)
        {
            Fraction res = new Fraction();
            res.numerator = ob1.sign * (ob1.intPart * ob1.denominator +
                 ob1.numerator) * ob2.denominator + ob2.sign * (ob2.intPart *
                 ob2.denominator + ob2.numerator) * ob1.denominator;
            res.denominator = ob1.denominator * ob2.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        // метод сложения дроби с целым числом
        static public Fraction operator +(Fraction ob1, int a)
        {
            // если к дроби прибавляется число, равное 0,
            // результат совпадает с операндом-дробью
            if (a == 0)
                return new Fraction(ob1.numerator, ob1.denominator,
                                             ob1.intPart, ob1.sign);
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 + ob2;       //сложение двух дробей
            return res;
        }

        // метод сложения целого числа и дроби
        static public Fraction operator +(int a, Fraction ob1)
        {
            // если к дроби прибавляется число, равное 0,
            // результат совпадает с операндом-дробью
            if (a == 0)
                return new Fraction(ob1.numerator, ob1.denominator,
                                             ob1.intPart, ob1.sign);
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 + ob2;       //сложение двух дробей
            return res;
        }

        // метод изменение знака дроби на противоположный
        static public Fraction operator -(Fraction ob)
        {
            ob.sign = -1;
            return ob;
        }

        // метод вычитания двух дробей
        static public Fraction operator -(Fraction ob1, Fraction ob2)
        {
            Fraction res = new Fraction();
            res.numerator = ob1.sign * (ob1.intPart * ob1.denominator +
                 ob1.numerator) * ob2.denominator - ob2.sign * (ob2.intPart *
                 ob2.denominator + ob2.numerator) * ob1.denominator;
            res.denominator = ob1.denominator * ob2.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        // метод вычитания из дроби целого числа
        static public Fraction operator -(Fraction ob1, int a)
        {
            if (a == 0)
                return new Fraction(ob1.numerator, ob1.denominator,
                                             ob1.intPart, ob1.sign);
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 - ob2;
            return res;
        }

        // метод вычитания дроби из целого числа
        static public Fraction operator -(int a, Fraction ob1)
        {
            if (a == 0)
                return new Fraction(ob1.numerator, ob1.denominator,
                                             ob1.intPart, -1);
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 - ob2;
            return res;
        }
        // метод умножения двух дробей
        static public Fraction operator *(Fraction ob1, Fraction ob2)
        {
            Fraction res = new Fraction();
            res.numerator = ob1.sign * ob2.sign * ob1.numerator * ob2.numerator;
            res.denominator = ob1.denominator * ob2.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        // метод умножения дроби на целое число
        static public Fraction operator *(Fraction ob1, int a)
        {
            if (a == 0)
                return new Fraction();
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 * ob2;
            return res;
        }

        // метод умножения целого числа и дроби
        static public Fraction operator *(int a, Fraction ob1)
        {
            if (a == 0)
                return new Fraction();
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 * ob2;
            return res;
        }

        // метод деления двух дробей
        static public Fraction operator /(Fraction ob1, Fraction ob2)
        {
            Fraction res = new Fraction();
            res.numerator = ob1.sign * ob1.numerator * ob2.denominator;
            res.denominator = ob2.sign * ob2.numerator * ob1.denominator;
            if (res.numerator < 0)
            {
                res.numerator *= -1;
                res.sign = -1;
            }
            res.GetMixedView();
            return res;
        }

        // метод деления дроби на целое число
        static public Fraction operator /(Fraction ob1, int a)
        {
            if (a == 0)
                throw new Exception("Деление на 0!");
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 / ob2;
            return res;
        }

        // метод деления целого числа на дробь
        static public Fraction operator /(int a, Fraction ob1)
        {
            if (a == 0)
                return new Fraction();
            // создание новой дроби ob2 = a
            Fraction ob2 = new Fraction(0, 1, Math.Abs(a), a / Math.Abs(a));
            Fraction res = ob1 / ob2;
            return res;
        }

        // методы сравнения двух дробей
        public static bool operator >(Fraction ob1, Fraction ob2)
        {
            if ((double)ob1 <= (double)ob2)
                return false;
            return true;
        }
        public static bool operator <(Fraction ob1, Fraction ob2)
        {
            if ((double)ob1 >= (double)ob2)
                return false;
            return true;
        }

        public static bool operator >=(Fraction ob1, Fraction ob2)
        {
            if ((double)ob1 < (double)ob2)
                return false;
            return true;
        }

        public static bool operator <=(Fraction ob1, Fraction ob2)
        {
            if ((double)ob1 > (double)ob2)
                return false;
            return true;
        }

        public static bool operator !=(Fraction ob1, Fraction ob2)
        {
            if (ob1.sign == ob2.sign && ob1.intPart == ob2.intPart &&
               ob1.numerator * ob2.denominator ==
                               ob1.denominator * ob2.numerator)
                return false;
            return true;
        }

        public static bool operator ==(Fraction ob1, Fraction ob2)
        {
            if (ob1.sign != ob2.sign || ob1.intPart != ob2.intPart ||
               ob1.numerator * ob2.denominator !=
                               ob1.denominator * ob2.numerator)
                return false;
            return true;
        }

        // статический метод преобразования строки в дробь
        public static Fraction Parse(string str)
        {
            int intPart, numerator, denominator, sign;
            // разделение строки на подстроки
            // с помощью разделителя-пробела
            string[] strs = str.Split(' ');
            string[] strs1;
            Fraction res;
            if (strs.Length == 1)
            {
                // в строке не было найдено пробелов
                // производим разделение строки по символу ‘/’
                strs1 = str.Split('/');
                if (strs1.Length == 1)
                {
                    // число задано в виде только целой части
                    // выделяем целую часть
                    intPart = int.Parse(strs1[0]);
                    // в зависимости от значения целой части,
                    // формируем новую дробь
                    if (intPart != 0)
                        res = new Fraction(0, 1, Math.Abs(intPart),
                                    intPart / Math.Abs(intPart));
                    else
                        res = new Fraction(0, 1, Math.Abs(intPart), 1);
                    return res;
                }
                else
                {
                    // число задано в виде только дробной части
                    // выделяем отдельно числитель и знаменатель
                    numerator = int.Parse(strs1[0]);
                    denominator = int.Parse(strs1[1]);
                    sign = 1;
                    // определяем знак числа по знаку числителя
                    if (numerator < 0)
                    {
                        numerator = -numerator;
                        sign = -1;
                    }
                    // формируем новую дробь и приводим ее
                    // к несократимому виду
                    res = new Fraction(numerator, denominator, 0, sign);
                    res.GetMixedView();
                    return res;
                }
            }
            // дробь задана в смешанном виде
            // отделяем дробную часть по разделителю ‘/’
            strs1 = strs[1].Split('/');
            intPart = int.Parse(strs[0]);
            // определяем знак числа по знаку целой части
            if (intPart < 0)
            {
                intPart = -intPart;
                sign = -1;
            }
            else
                sign = 1;
            numerator = int.Parse(strs1[0]);
            denominator = int.Parse(strs1[1]);
            // формируем новую дробь и приводим ее
            // к несократимому виду
            res = new Fraction(numerator, denominator, intPart, sign);
            res.GetMixedView();
            return res;
        }

        // метод получения строкового представления дроби – оператор
        // преобразования в символьную строку
        public static implicit operator string(Fraction ob)
        {
            string res = "";
            // знак числа выводится, только если число отрицательно
            if (ob.sign < 0)
                res = res + "-";
            // если целая часть не равна 0, выводим ее
            if (ob.intPart != 0)
                res = res + ob.intPart;
            // дробная часть печатается, если числитель не равен 0
            if (ob.numerator != 0)
                res = res + " " + ob.numerator + "/" + ob.denominator;
            // если и целая часть и дробная часть равны 0,
            // то число равно 0
            if (ob.intPart == 0 && ob.numerator == 0)
                res = "0";
            return res;
        }

        public int CompareTo(object ob)
        {
            if (this < (ob as Fraction)) return -1;
            if (this > (ob as Fraction)) return 1;
            return 0;
        }
    }
}
