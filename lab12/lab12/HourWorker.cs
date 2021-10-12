using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    class HourWorker : Worker
    {

        public override double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }

        protected int hours { get; set; }

        public HourWorker() : base()
        {
            salary = 0;
            hours = 0;
        }

        public HourWorker(string surname, string name, DateTime dob, char gender, double salary, int bonuspercentage, int experience, int hours) : base(surname, name, dob, gender, salary, bonuspercentage, experience)
        {
            this.salary = salary;
            this.hours = hours;
        }

        public void inputHW(HourWorker a)
        {
            Console.WriteLine("Введите Фамилию: ");
            base.surname = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            base.name = Console.ReadLine();
            Console.WriteLine("Введите Дату рождения: ");
            base.dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите Гендер/пол: ");
            base.Gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите Плату за час: ");
            a.salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Время работы(в часах): ");
            a.hours = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Процент премии: ");
            a.bonuspercentage = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Опыт работы: ");
            a.experience = int.Parse(Console.ReadLine());
        }

        public void outputHW(HourWorker a)
        {
            Console.WriteLine("Фамилия: " + base.surname);
            Console.WriteLine("Имя: " + base.name);
            Console.WriteLine("Дата рождения: " + base.dob);
            Console.WriteLine("Гендер/пол: " + base.gender);
            Console.WriteLine("Плата за час: " + a.salary + " руб.");
            Console.WriteLine("Количество рабочих часов: " + a.hours + " ч.");
            Console.WriteLine("Процент премии: " + a.bonuspercentage + "%");
            Console.WriteLine("Стаж работы: " + a.experience + " года/лет.");
        }

        public double income(HourWorker a)
        {
            double x = a.salary * a.hours + a.salary * a.bonuspercentage / 100;
            return x;
        }

        public double incometax(HourWorker a)
        {
            double x = a.salary * a.hours * 13 / 100;
            return x;
        }

        public double wage(HourWorker a)
        {
            double x = a.income(a) - a.incometax(a);
            return x;
        }

        public void goodworker(HourWorker a)
        {
            if (a.experience >= 10)
            {
                a.bonuspercentage = a.bonuspercentage * 2;
            }
        }





    }
}
