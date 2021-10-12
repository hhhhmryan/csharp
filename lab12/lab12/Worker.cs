using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    class Worker : Person
    {
        public double salary;
        public virtual double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                if (value > 5000)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("Оклад не может быть мельше 5000.");
                }
            }
        }
        public int bonuspercentage { get; set; }
        public int experience { get; set; }

        public Worker() : base()
        {
            salary = 0;
            bonuspercentage = 0;
            experience = 0;
        }

        public Worker(string surname, string name, DateTime dob, char gender, double salary, int bonuspercentage, int experience) : base(surname, name, dob, gender)
        {
            this.salary = salary;
            this.bonuspercentage = bonuspercentage;
            this.experience = experience;
        }

        public void inputW(Worker a)
        {
            Console.WriteLine("Введите Фамилию: ");
            base.surname = Console.ReadLine();
            Console.WriteLine("Введите Имя: ");
            base.name = Console.ReadLine();
            Console.WriteLine("Введите Дату рождения: ");
            base.dob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите Гендер/пол: ");
            base.Gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите Оклад рабочего: ");
            a.salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Процент премии: ");
            a.bonuspercentage = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Опыт работы: ");
            a.experience = int.Parse(Console.ReadLine());
        }

        public void outputW(Worker a)
        {
            Console.WriteLine("Фамилия: " + base.surname);
            Console.WriteLine("Имя: " + base.name);
            Console.WriteLine("Дата рождения: " + base.dob);
            Console.WriteLine("Гендер/пол: " + base.gender);
            Console.WriteLine("Оклад рабочего: " + a.salary + " руб.");
            Console.WriteLine("Процент премии: " + a.bonuspercentage + "%");
            Console.WriteLine("Стаж работы: " + a.experience + " года/лет.");
        }

        public double income(Worker a)
        {
            double x = a.salary + a.salary * a.bonuspercentage / 100;
            return x;
        }

        public double incometax(Worker a)
        {
            double x = a.salary * 13 / 100;
            return x;
        }

        public double wage(Worker a)
        {
            double x = a.income(a) - a.incometax(a);
            return x;
        }

        public void goodworker(Worker a)
        {
            if (a.experience >= 10)
            {
                a.bonuspercentage = a.bonuspercentage * 2;
            }
        }


    }
}
